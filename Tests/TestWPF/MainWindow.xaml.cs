using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestWPF.model;

namespace TestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        EmailSendServiceClass emailSendServiceClass;
       
        public MainWindow()
        {  
            InitializeComponent();
            WpfTestMailSender.FromSend = new MailAddress("yaolsher@yandex.ru");
            WpfTestMailSender.ToSend = new MailAddress("olsher92@mail.ru");
              emailSendServiceClass = new EmailSendServiceClass();
            emailSendServiceClass.MainForm = this;

        }

      
        private void SendButtonClick(object sender, RoutedEventArgs e)
        {
            emailSendServiceClass.Subject = textSubject.Text;
            emailSendServiceClass.Body = textBody.Text;           
            emailSendServiceClass.MailSend(Login.Text, PasswordEdit);
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
