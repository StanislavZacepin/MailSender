namespace WpfMailSender.Models
{
    public class Server
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Port { get; set; }
        public bool UseSSL { get; set; }
        public bool Login { get; set; }
        public bool Password { get; set; }
    }
}
