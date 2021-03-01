using WpfMailSender.Models.Base;

namespace WpfMailSender.Models
{
    public class Message : Entity
    {
        public string Title { get; set; }
        public string Text { get; set; }
    }
}
