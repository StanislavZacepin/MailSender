using System;
using System.ComponentModel;
using WpfMailSender.Models.Base;

namespace WpfMailSender.Models
{
    public class Recipent : Entity, IDataErrorInfo
    {
        private string _Name;

        public string this[string columnName] => throw new NotImplementedException();

        public string Name 
        { 
            get => _Name;
            set
            {
                //if (string.IsNullOrEmpty(value))
                //     throw new ArgumentException("Не задоно имя!"); 

                _Name = value;
            }
        }
        public string Address { get; set; }

        string IDataErrorInfo.Error => null;

         string IDataErrorInfo.this[string PropertyName]
        {
            get
            {
                switch (PropertyName)
                {
                    default: return null;

                    case nameof(Name):
                        var name = Name;

                        if (name is null) return "Имя не может быть пустой ссылкой";
                        if (name.Length < 3) return "Длина имени должна быть не менее 3 символов";
                        if (name.Length > 20) return "Длина имени должна быть не более 20 символов";
                        return null;
                }
            }
        }
    }
}
