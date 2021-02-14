using System.Net;
using System.Net.Mail;


namespace TestWPF.model
{
    public static class WpfTestMailSender
    {
        public static string AdresServer = "smtp.yandex.ru";
        public  static int portServer = 25;
       
        #region MailAdress
        public static MailAddress From = new MailAddress("yaolsher@yandex.ru", "Стас");
        public static MailAddress to = new MailAddress("olsher258@mail.ru", "Стас");
        #endregion
        
        public static string Subject = "Заголовок";
        public static string Body = "Текст писма";

    }
}
