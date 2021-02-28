using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMailSender.Models
{
    class SchedulerTask
    { 
        public DateTime Time { get; set; }
        public Server Server { get; set; }
        public Sender Sender { get; set; }
        public List<Recipent> Recipents { get; set; }      
        public Message Message { get; set; }

       // public List<Message> Messages { get; set; } = new();
    }
}
