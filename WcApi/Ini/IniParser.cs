using System;
using System.Collections;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WcApi.Ini
{
    public class IniParser
    {
        private readonly Hashtable _keyPairs = new Hashtable();
        private string _path;

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        public bool UpperKey { get; set; }

        private struct SectionPair
        {
            public string Section;
            public string Key;
        }

        public IniParser()
        {

        }

        public IniParser(string path)
        {
            _path = path;
            Parse();
        }

        public void Parse(TextReader iniFile = null)
        {
            string currentRoot = null;

            if (File.Exists(_path))
            {
                try
                {
                    if (iniFile == null)
                        iniFile = new StreamReader(_path, Encoding.GetEncoding("cp866"));

                    using (iniFile)
                    {
                        string line = iniFile.ReadLine();

                        while (line != null)
                        {
                            line = line.Trim();
                            if (!string.IsNullOrEmpty(line))
                            {
                                if (line.StartsWith("[") && line.EndsWith("]"))
                                    currentRoot = line.Substring(1, line.Length - 2);
                                else
                                {
                                    var keyPair = line.Split(new[] {'='}, 2);
                                    SectionPair sectionPair;
                                    string value = null;

                                    if (currentRoot == null)
                                        currentRoot = "Root";

                                    sectionPair.Section = currentRoot;
                                    sectionPair.Key = UpperKey ? keyPair[0].ToUpper() : keyPair[0];

                                    if (keyPair.Length > 1)
                                        value = keyPair[1];

                                    _keyPairs.Add(sectionPair, value);
                                }
                            }
                            line = iniFile.ReadLine();
                        }
                    }
                }
                catch (Exception e)
                {
                    // ReSharper disable once PossibleIntendedRethrow
                    throw e;
                }
                finally
                {
                    iniFile?.Close();
                }
            }
            else
                throw new FileNotFoundException($"Файл {_path} не найден.");
        }

        public string GetSetting(string sectionName, string settingName)
        {
            SectionPair sectionPair;
            sectionPair.Section = sectionName;
            sectionPair.Key = UpperKey ? settingName.ToUpper() : settingName;
            return (string) _keyPairs[sectionPair];
        }

        public string[] EnumSection(string sectionName)
        {
            ArrayList tmpArrayList = new ArrayList();

            foreach (SectionPair pair in _keyPairs.Keys)
            {
                if (pair.Section == sectionName)
                    tmpArrayList.Add(pair.Key);
            }

            return (string[]) tmpArrayList.ToArray(typeof(string));
        }

        public void AddSetting(string sectionName, string settingName, string settingValue)
        {
            SectionPair sectionPair;
            sectionPair.Section = sectionName;
            sectionPair.Key = settingName;

            if(_keyPairs.ContainsKey(sectionPair))
                _keyPairs.Remove(sectionPair);
            _keyPairs.Add(sectionPair, settingValue);
        }

        public void AddSetting(string sectionName, string settingName)
        {
            AddSetting(sectionName, settingName, null);
        }

        public void DeleteSetting(string sectionName, string settingName)
        {
            SectionPair sectionPair;
            sectionPair.Section = sectionName;
            sectionPair.Key = settingName;

            if(_keyPairs.ContainsKey(sectionPair))
                _keyPairs.Remove(sectionPair);
        }

        private string ConfigToString()
        {
            ArrayList sections = new ArrayList();
            string stringToSave = "";

            foreach (SectionPair pair in _keyPairs.Keys)
            {
                if (!sections.Contains(pair.Section))
                    sections.Add(pair.Section);
            }

            foreach (string section in sections)
            {
                stringToSave += $"[{section}]\r\n";

                foreach (SectionPair sectionPair in _keyPairs.Keys)
                {
                    if (sectionPair.Section == section)
                    {
                        var tmpValue = (string)_keyPairs[sectionPair];

                        if (!string.IsNullOrEmpty(tmpValue))
                            tmpValue = $"={tmpValue}";
                        else
                            tmpValue = "=";

                        stringToSave += $"{sectionPair.Key}{tmpValue}\r\n";
                    }
                }

                stringToSave += "\r\n";
            }

            return stringToSave;
        }

        public void Save(StreamWriter writer)
        {
            string stringToSave = ConfigToString();
            writer.Write(stringToSave);
        }

        public void SaveSettings(string filePath)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(filePath, false, Encoding.GetEncoding("cp866")))
                {
                    Save(sw);
                }
            }
            catch (Exception e)
            {
                // ReSharper disable once PossibleIntendedRethrow
                throw e;
            }
        }

        public void SaveSettings()
        {
            SaveSettings(_path);
        }
    }
}
