using System.Net.Mail;

namespace TestConsole.model
{
    public static class WpfTestMailSender
    {
        public static string AdresServer = "smtp.yandex.ru";
        public  static int portServer = 465;
        public static string UserName = "sadasd";
        public static string Pasword = "sfdsf";
        #region MailAdress
        public static MailAddress From = new MailAddress("olsher92@mail.ru", "Стас");
        public static MailAddress to = new MailAddress("olsher258@mail.ru", "Стас");
        #endregion
        
        public static string Subject = "Заголовок";
        public static string Body = "Текст писма";

    }
}
