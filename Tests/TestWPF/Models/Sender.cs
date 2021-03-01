using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMailSender.Models.Base;

namespace WpfMailSender.Models
{
    public class Sender : Entity
    {
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
