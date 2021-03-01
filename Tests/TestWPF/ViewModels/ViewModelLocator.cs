using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using TestWPF;
using WpfMailSender.ViewModels;


namespace WpfMailSender.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainWindowViewModel => App.Services.GetRequiredService<MainWindowViewModel>();

        public StatisticViemModel Statistic => App.Services.GetRequiredService<StatisticViemModel>();
    }
}
