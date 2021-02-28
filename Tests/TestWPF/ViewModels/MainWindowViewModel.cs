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
using WpfMailSender.Infastructure.Services;
using WpfMailSender.Infastructure.Services.InMemory;
using WpfMailSender.Models;
using WpfMailSender.Models.Base;

namespace WpfMailSender.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        private readonly IRepository<Server> _Servers;
        private readonly IRepository<Sender> _Senders;
        private readonly IRepository<Recipent> _Recipents;
        private readonly IRepository<Message> _Messages;
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

        public MainWindowViewModel(
            IRepository<Server> servers,
            IRepository<Sender> sender, 
            IRepository<Recipent> recipent,
            IRepository<Message> message, IMailService MailService)
        {
            _Servers = servers;
            _Senders = sender;
            _Recipents = recipent;
            _Messages = message;

            _MailService = MailService;
        }

        private static void Load<T>(ObservableCollection<T> collection, IRepository<T> rep) where T : Entity
        {
            collection.Clear();
            foreach (var item in rep.GetAll())
                collection.Add(item);
        }
        private void LoadServers()
        {
            Load(Servers,_Servers);
            Load(Recipients,_Recipents);
            Load(Senders,_Senders);
            Load(Messages,_Messages);
          
        }
    }
}
