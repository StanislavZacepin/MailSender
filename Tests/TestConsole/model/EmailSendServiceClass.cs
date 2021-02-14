using System.Net;
using System.Net.Mail;
using TestConsole.model;

namespace TestConsole.model
{
    
        public class EmailSendServiceClass
        {
            public EmailSendServiceClass( )
            {
               
                var message = new MailMessage(WpfTestMailSender.From, WpfTestMailSender.to); 
                message.Subject = WpfTestMailSender.Subject;
                message.Body = WpfTestMailSender.Body;
                var client = new SmtpClient(WpfTestMailSender.AdresServer, WpfTestMailSender.portServer);
                client.Credentials = new NetworkCredential
                  {
                     UserName = WpfTestMailSender.UserName,
                     Password = WpfTestMailSender.Pasword
                  };
                client.EnableSsl = true;
                client.Timeout = 1000;
             
                client.Send(message);
            }

        }
}
