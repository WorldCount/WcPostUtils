using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WcApi.Xml;

namespace ListEditor.Models
{
    public class ValidateField : IComparable
    {
        public string Name { get; set; }

        public ValidateField() { }

        public ValidateField(string name)
        {
            Name = name;
        }

        public int CompareTo(object obj)
        {
            ValidateField v = obj as ValidateField;
            if (v != null)
                return String.Compare(Name, v.Name, StringComparison.Ordinal);
            else
                throw new Exception("Невозможно сравнить два объекта");
        }
    }

    public class ValidateFields
    {
        public List<ValidateField> Fields { get; set; } = new List<ValidateField>();

        public void Add(ValidateField validateField)
        {
            Fields.Add(validateField);
        }

        public void Save(string filePath)
        {
            Fields = Fields.OrderBy(n => n).ToList();
            Serializer.Save(filePath, this);
        }

        public static ValidateFields Load(string filePath)
        {
            if(!File.Exists(filePath))
                return new ValidateFields();
            ValidateFields validateFields = Serializer.Load<ValidateFields>(filePath);
            return validateFields;
        }

        public string[] ToArray()
        {
            List<string> res = new List<string>();
            foreach (ValidateField field in Fields)
            {
                res.Add(field.Name);
            }
            return res.ToArray();
        }
    }
}
