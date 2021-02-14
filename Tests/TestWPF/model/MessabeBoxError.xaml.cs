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
using System.Windows.Shapes;
using TestWPF;

namespace TestWPF.model
{
    /// <summary>
    /// Логика взаимодействия для MessabeBoxError.xaml
    /// </summary>
    public partial class MessabeBoxError : Window
    {
        private MainWindow f { get; set; }
        public MessabeBoxError()
        {
            InitializeComponent();
        }

        public MessabeBoxError(MainWindow form)
        {
            form.Hide();
            InitializeComponent();
            f = form;
        }
        public MessabeBoxError(MainWindow form ,string TextHide, string Body)
        {
            HeadWindow.Title = TextHide;
            BodyWindow.Content = Body;
            form.Hide();
            InitializeComponent();
            f = form;
        }
        private void ExitClickButton(object sender, RoutedEventArgs e)
        {
            f.Show();
            Close();
        }
    }
}
