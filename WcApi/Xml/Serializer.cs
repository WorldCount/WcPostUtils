using System;
using System.IO;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WcApi.Xml
{
    public static class Serializer
    {
        /// <summary>
        /// Сохраняет объект в Xml
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <param name="filePath">Путь к файлу</param>
        /// <param name="saveObject">Сохраняемый объект</param>
        public static void Save<T>(string filePath, T saveObject)
        {
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(sw, saveObject);
            }
        }

        /// <summary>
        /// Загружает объект из Xml
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <param name="filePath">Путь к файлу</param>
        /// <returns>Загруженный объект</returns>
        public static T Load<T>(string filePath)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(sr);
                }
            }
            return default(T);
        }

        /// <summary>
        /// Загружает объект из Xml по Uri
        /// </summary>
        /// <typeparam name="T">Тип объекта</typeparam>
        /// <param name="uri">Ссылка на файл</param>
        /// <returns>Загруженный объект</returns>
        public static T Load<T>(Uri uri)
        {
            try
            {
                XmlTextReader reader = new XmlTextReader(uri.ToString());
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                return (T)serializer.Deserialize(reader);
            }
            catch
            {
                return default(T);
            }
        }

        public static async Task<T> LoadAsync<T>(Uri uri)
        {
            return await Task.Run(() => Load<T>(uri));
        }

        public static async Task<T> LoadAsync<T>(string path)
        {
            return await Task.Run(() => Load<T>(path));
        }
    }
}
