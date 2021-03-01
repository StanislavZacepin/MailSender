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

namespace WpfMailSender.Controls
{
    /// <summary>
    /// Логика взаимодействия для ItemsPanel.xaml
    /// </summary>
    public partial class ItemsRecipent : UserControl
    {
        public static readonly DependencyProperty TitleProperty = 
            DependencyProperty.Register(
                nameof(Title),
                typeof(string),
                typeof(ItemsRecipent),
                new PropertyMetadata("(Получатель)", OnTitleChanged));

        private static void OnTitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
           
        }

        public string Title 
        { 
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty,value);
        }
        public ItemsRecipent() => InitializeComponent();

        private void DockPanel_SizeChanged(object sender, SizeChangedEventArgs e)
        {

        }
    }
}
