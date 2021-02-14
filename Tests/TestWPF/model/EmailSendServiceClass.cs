using System;
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
            try
            {
                client.Send(message);
                MessageBox.Show("Почта успешно отправлена!", "Отправка почты", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (SmtpException)  
            {
                MessageBox.Show("Ошибка авторизации", "Ошибка отпрвки почты", MessageBoxButton.OK, MessageBoxImage.Error);
                
            }
            catch(TimeoutException)
            {
                MessageBox.Show("Ошибка адреса сервера", "Ошибка отправки почты", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            }

        }
}
