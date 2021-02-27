using System;
using System.Timers;
using MailSender.lib.Interfaces;
using MailSender.lib.ViewModels.Base;

namespace WpfMailSender.ViewModels
{
    class StatisticViemModel : ViewModel
    {
        private readonly IStatistic _Statistic;

        public int MailsSendedCount => _Statistic.SendedMailsCount;

        public int SendersCount => _Statistic.SendersCount;

        public int RecipientsCount => _Statistic.RecipientsCount;

        public TimeSpan UpTime => _Statistic.UpTime;
        public StatisticViemModel(IStatistic Statistic) 
        {
            _Statistic = Statistic;

            var timer = new Timer(100);

            timer.Elapsed += (_, _) => OnPropertyChanged(nameof(UpTime));
            timer.Start();

            Statistic.SendedMailsCountChanged += (_, _) => OnPropertyChanged(nameof(MailsSendedCount));
        }
    }
}
