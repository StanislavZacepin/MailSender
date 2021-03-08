using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MailSender.lib.Entities.Base;

namespace WpfMailSender.Models
{
    public class SchedulerTask : Entity
    {
        public DateTime Time { get; set; } = DateTime.Now;
        [Required]
        public Server Server { get; set; }
        [Required]
        public Sender Sender { get; set; }
        public ICollection<Recipent> Recipents { get; set; }
        [Required]
        public Message Message { get; set; }

       // public List<Message> Messages { get; set; } = new();
    }
}
