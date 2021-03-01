using System.Windows.Controls;

namespace WpfMailSender.Views
{
    /// <summary>
    /// Логика взаимодействия для RecipientEdit.xaml
    /// </summary>
    public partial class RecipientEditor 
    {
        public RecipientEditor()
        {
            InitializeComponent();
        }
        private void OnNameValidationError(object? Sender, ValidationErrorEventArgs E)
        {
            if(E.Action == ValidationErrorEventAction.Added)
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
