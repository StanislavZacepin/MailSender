using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;

namespace EmailSendServiceDLL
{
    public class EmailSendService : IDisposable
    {

        public string ServerAddress { get; set; }

        public int ServerPort { get; set; }

        public bool UseSSL { get; set; }

        public string Login { get; set; }

        public string Password { get; set; }

        public void Dispose() { }


        public void SendMessage(string SenderAddress, string RecipientAddress, string Subject, string Body)
        {
            var from = new MailAddress(SenderAddress);
            var to = new MailAddress(RecipientAddress);

            MailMessage message = new MailMessage(from, to)
            {
                Subject = Subject,
                Body = Body
            };

            SmtpClient client = new SmtpClient(ServerAddress, ServerPort)
            {
                EnableSsl = UseSSL,
                Credentials = new NetworkCredential
                {
                    UserName = Login,
                    Password = Password
                }
            };
            client.Send(message);
            Dispose();
        }
    }
}