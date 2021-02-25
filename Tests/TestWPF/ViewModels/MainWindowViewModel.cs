using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using MailSender.lib.Commands.Base;
using MailSender.lib.ViewModels.Base;
using WpfMailSender.Infastructure;
using WpfMailSender.Models;

namespace WpfMailSender.ViewModels
{
    class MainWindowViewModel : ViewModel
    {
        private readonly ServersRepository _Servers;

        private string _Title = "Рассыльщик";

        public string Title { get => _Title; set => Set(ref _Title, value);}

        private string _Status = "Готов!";

        public string Status { get => _Status; set => Set(ref _Status, value); }

        public ObservableCollection<Server> Servers { get; } = new ();

        #region Команды

        private ICommand _LoadServersComand;

        public ICommand LoadServersComand => _LoadServersComand
            ??= new LambdaCommand(OnLoadServersCommandExecuted, CanLoadServersCommandExecute);

        private bool CanLoadServersCommandExecute(object p) => Servers.Count == 0;

        private void OnLoadServersCommandExecuted(object p)
        {
            LoadServers();
        }

        #endregion

        public MainWindowViewModel(ServersRepository servers) => _Servers = servers;

        private void LoadServers()
        {
            foreach (var server in _Servers.GetAll())
            {
                Servers.Add(server);
            }
        }
    }
}
