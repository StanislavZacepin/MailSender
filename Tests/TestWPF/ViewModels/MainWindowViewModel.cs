using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MailSender.lib.Commands;
using MailSender.lib.Interfaces;
using MailSender.lib.ViewModels.Base;
using WpfMailSender.Infastructure;
using WpfMailSender.Models;

namespace WpfMailSender.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        private readonly ServersRepository _Servers;
        private readonly IMailService _MailService;
        private string _Title = "Рассыльщик";

        public string Title { get => _Title; set => Set(ref _Title, value);}

        private string _Status = "Готов!";

        public string Status { get => _Status; set => Set(ref _Status, value); }

        public ObservableCollection<Server> Servers { get; } = new ();
        public ObservableCollection<Recipent> Recipients { get; } = new ();
        public ObservableCollection<Sender> Senders { get; } = new ();
        public ObservableCollection<Message> Messages { get; } = new ();

        #region Команды

        private ICommand _LoadServersComand;

        public ICommand LoadServersComand => _LoadServersComand
            ??= new LambdaCommand(OnLoadServersCommandExecuted, CanLoadServersCommandExecute);

        private bool CanLoadServersCommandExecute(object p) => Servers.Count == 0;

        private void OnLoadServersCommandExecuted(object p)
        {
            LoadServers();
        }
         private ICommand _SendEmailComand;

        public ICommand SendEmailComand => _SendEmailComand
            ??= new LambdaCommand(OnSendServersCommandExecuted, CanSendServersCommandExecute);

        private bool CanSendServersCommandExecute(object p) => Servers.Count == 0;

        private void OnSendServersCommandExecuted(object p)
        {
            _MailService.SendEmail("Иванов", "Смирнов", "Тема", "Тело письма");
        }


        #endregion

        public MainWindowViewModel(ServersRepository servers, IMailService MailService)
        {
            _Servers = servers;
            _MailService = MailService;
        }

        private void LoadServers()
        {
            foreach (var server in _Servers.GetAll())
            {
                Servers.Add(server);
            }
        }
    }
}
