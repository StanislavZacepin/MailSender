using System;
using Microsoft.EntityFrameworkCore;

namespace MailSender.lib.Interfaces
{
    public interface IStatistic
    {
        int SendedMailsCount { get; }
        event EventHandler SendedMailsCountChanged;
        void MailSended();

        int SendersCount { get; }

        int RecipientsCount { get; }

        TimeSpan UpTime { get; }
    }
}
