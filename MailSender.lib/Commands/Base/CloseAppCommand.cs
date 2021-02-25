using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using MailSender.lib.Commands.Base;

namespace MailSender.lib.Commands.Base
{
    public class CloseAppCommand : Command
    {
        public override void Execute(object parameter) => Application.Current.Shutdown();

    }
}
