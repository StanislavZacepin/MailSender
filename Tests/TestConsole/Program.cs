using System;
using System.Net;
using System.Net.Mail;
using TestConsole.model;

namespace TestConsole
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var client = new SmtpClient(WpfTestMailSender.AdresServer, WpfTestMailSender.portServer);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential
            {
                UserName = WpfTestMailSender.UserName,
                Password = WpfTestMailSender.Pasword
            };
            var message = new MailMessage(WpfTestMailSender.From, WpfTestMailSender.to);
            message.Subject = WpfTestMailSender.Subject;
            message.Body = WpfTestMailSender.Body;
            client.Send(message);
        }
    }
}
