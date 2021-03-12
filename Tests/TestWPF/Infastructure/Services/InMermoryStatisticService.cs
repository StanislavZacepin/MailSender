using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using MailSender.lib.Interfaces;
using WpfMailSender.Data;
using WpfMailSender.Models;

namespace WpfMailSender.Infastructure.Services
{
    internal class InMermoryStatisticService : IStatistic
    {
        private int _SendedMailsCount;
        public int SendedMailsCount => _SendedMailsCount;
        public event EventHandler SendedMailsCountChanged;

        public void MailSended()
        {
            _SendedMailsCount++;
            SendedMailsCountChanged?.Invoke(this, EventArgs.Empty);
        }

        public int SendersCount => TestData.Senders.Count;
        public int RecipientsCount => TestData.Recipentss.Count;

        private readonly Stopwatch StopwatchTimer = Stopwatch.StartNew();
        public TimeSpan UpTime => StopwatchTimer.Elapsed;

        public List<Recipent> Listrecipents => TestData.Recipentss;
    }
}
