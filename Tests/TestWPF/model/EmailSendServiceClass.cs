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
        public MailMessage Message { get; set; }
        public SmtpClient client { get; set; }

        public string Login { get; set; }

        public PasswordBox Password { get; set; }

        public MainWindow MainForm { get; set; }

        public string Subject { get; set; }
        public string Body { get; set; }
        public EmailSendServiceClass()
        {
            Message = new MailMessage(WpfTestMailSender.FromSend, WpfTestMailSender.ToSend);           
            client = new SmtpClient(WpfTestMailSender.AdresServer, WpfTestMailSender.PortServer);           
        }
        public void  MailSend(string Login, PasswordBox Password)
        {
            Message.Subject = Subject;
            Message.Body = Body;
            client.Credentials = new NetworkCredential
            {
                UserName = Login,
                SecurePassword = Password.SecurePassword
            };
            client.EnableSsl = true;
            client.Timeout = 1000;
            try
            {
                client.Send(Message);
                MessabeBoxFinish messabeBoxFinish = new MessabeBoxFinish(MainForm);
                messabeBoxFinish.Show();
            }
            catch (SmtpException)  
            {
                MessabeBoxError messabeBoxError = new MessabeBoxError(MainForm);
                messabeBoxError.Show();
                

            }
            catch(TimeoutException)
            {
                MessabeBoxError messabeBoxError = new MessabeBoxError(MainForm, "Ошибка адреса сервера", "Ошибка отправки почты");
                 messabeBoxError.Show();                
            }
        }
    }
}


