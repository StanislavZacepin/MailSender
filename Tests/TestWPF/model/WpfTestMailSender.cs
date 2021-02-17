using System.Net;
using System.Net.Mail;


namespace TestWPF.model
{
    public static class WpfTestMailSender
    {
        public static string AdresServer { get;  } = "smtp.yandex.ru";
        public static int PortServer { get; } = 25;


        #region MailAdress
        public static MailAddress FromSend { get; set; }
        public static MailAddress ToSend { get; set; }
        #endregion
        
       

    }
}
