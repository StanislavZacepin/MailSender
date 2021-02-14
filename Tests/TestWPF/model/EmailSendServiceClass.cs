using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;



namespace TestWPF.model
{
    
        public class EmailSendServiceClass
        {
            public EmailSendServiceClass(string Login, PasswordBox Password )
            {
               
                var message = new MailMessage(WpfTestMailSender.From, WpfTestMailSender.to); 
                message.Subject = WpfTestMailSender.Subject;
                message.Body = WpfTestMailSender.Body;
                var client = new SmtpClient(WpfTestMailSender.AdresServer, WpfTestMailSender.portServer);
                client.Credentials = new NetworkCredential
                  {
                     UserName = Login,
                     SecurePassword = Password.SecurePassword
                };
                client.EnableSsl = true;
                client.Timeout = 1000;
             
                client.Send(message);
            }

        }
}
