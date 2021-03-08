using MailSender.lib.Entities.Base;

namespace WpfMailSender.Models
{
    public class Message : Entity
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
