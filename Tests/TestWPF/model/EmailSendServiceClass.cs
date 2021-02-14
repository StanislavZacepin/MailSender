using System;
using System.Net;
using System.Net.Mail;
using System.Windows;
using System.Windows.Controls;




namespace TestWPF.model
{
    delegate void Close();
        public class EmailSendServiceClass 
        {
            public EmailSendServiceClass(string Login, PasswordBox Password,string Subject, string Body, MainWindow main )
            {
               
                var message = new MailMessage(WpfTestMailSender.From, WpfTestMailSender.to); 
                message.Subject = Subject;
                message.Body = Body;
                var client = new SmtpClient(WpfTestMailSender.AdresServer, WpfTestMailSender.portServer);
                client.Credentials = new NetworkCredential
                  {
                     UserName = Login,
                     SecurePassword = Password.SecurePassword
                };
                client.EnableSsl = true;
                client.Timeout = 1000;
            try
            {
                client.Send(message);
                MessabeBoxFinish messabeBoxFinish = new MessabeBoxFinish(main);
                messabeBoxFinish.Show();
            }
            catch (SmtpException)  
            {
                MessabeBoxError messabeBoxError = new MessabeBoxError(main);
                messabeBoxError.Show();
                

            }
            catch(TimeoutException)
            {
                MessabeBoxError messabeBoxError = new MessabeBoxError(main, "Ошибка адреса сервера", "Ошибка отправки почты");
                messabeBoxError.Show();
                
            }
            }

        }
}
