using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WpfMailSender.Views
{
    /// <summary>
    /// Логика взаимодействия для SchedulerView.xaml
    /// </summary>
    public partial class SchedulerView : UserControl
    {
        
        public SchedulerView()
        {
            InitializeComponent();                     
        }
        private void OnTimeValidationError(object? Sender, ValidationErrorEventArgs E)
        {
            if (E.Action == ValidationErrorEventAction.Added)
            {
                ((Control)Sender).ToolTip = E.Error.ErrorContent.ToString();
            }
            else
            {
                ((Control)Sender).ClearValue(ToolTipProperty);
            }
        }
        
    }

}
