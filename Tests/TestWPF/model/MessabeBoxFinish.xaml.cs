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

namespace TestWPF.model
{
    /// <summary>
    /// Логика взаимодействия для MessabeBoxFinish.xaml
    /// </summary>
    public partial class MessabeBoxFinish : Window
    {
        private MainWindow f { get; set; }
        public MessabeBoxFinish()
        {
            InitializeComponent();
        }
        public MessabeBoxFinish(MainWindow form)
        {
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
