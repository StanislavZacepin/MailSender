using System;
using System.Collections.Generic;
using WpfMailSender.Models;

namespace MailSender.lib.Interfaces
{
    public interface IStatistic
    {
        int SendedMailsCount { get; }
        event EventHandler SendedMailsCountChanged;
        void MailSended();

        int SendersCount { get; }

        int RecipientsCount { get; }

        List<Recipent> Listrecipents { get; }

        TimeSpan UpTime { get; }
    }
}
