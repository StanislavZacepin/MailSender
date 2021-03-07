using System.Windows;
using System.Windows.Controls;


namespace TestWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void Exit_Click(object sender, RoutedEventArgs e) => Close();

        private void NexstV(object sender, RoutedEventArgs e)
        {
            TabontrolList.SelectedItem = TabScheduler;

        }
          private void OnTitleValidationError(object? Sender, ValidationErrorEventArgs E)
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
