using System.IO;

using ListEditor.Models;

namespace ListEditor.Libs
{
    public static class CheckRegionCity
    {
        private static readonly ValidateFields ValidateFields;
        private static readonly string DataPath = Path.Combine(Properties.Settings.Default.DataDir, Properties.Settings.Default.RegionCityFile);

        static CheckRegionCity()
        {
            ValidateFields = ValidateFields.Load(DataPath);
        }

        public static bool Validate(string city, string region)
        {
            bool result = true;

            for (int i = 0; i < ValidateFields.Fields.Count; i++)
            {
                if (city.Contains(ValidateFields.Fields[i].Name) || region.Contains(ValidateFields.Fields[i].Name))
                {
                    //MessageBox.Show($"{city}: {RegionCityNames[i]} -> {city.Contains(RegionCityNames[i])} | {region}: {RegionCityNames[i]} -> {region.Contains(RegionCityNames[i])}");
                    result = false;
                    break;
                }
            }

            return result;
        }
    }
}
