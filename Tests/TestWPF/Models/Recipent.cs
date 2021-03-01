using System;
using WpfMailSender.Models.Base;

namespace WpfMailSender.Models
{
    public class Recipent : Entity
    {
        private string _Name;

        public string Name 
        { 
            get => _Name;
            set
            {
                if (string.IsNullOrEmpty(value))
                     throw new ArgumentException("Не задоно имя!");

                _Name = value;
            }
        }
        public string Address { get; set; }
    }
}
