using System.Collections;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WpfMailSender.Controls
{
    /// <summary>
    /// Логика взаимодействия для ItemsPanel.xaml
    /// </summary>
    public partial class ItemsPanel : UserControl
    {
        public static readonly DependencyProperty TitleProperty = 
            DependencyProperty.Register(
                nameof(Title),
                typeof(string),
                typeof(ItemsPanel),
                new PropertyMetadata("(Название)"));

        #region AddNewItemCommand : ICommand - Добавления нового элемента

        public static readonly DependencyProperty AddNewItemCommandProperty =
              DependencyProperty.Register(
                  nameof(AddNewItemCommand),
                  typeof(ICommand),
                  typeof(ItemsPanel),
                  new PropertyMetadata(default(ICommand)));
        //[Descriotion("Добавления нового элемента")]
        public ICommand AddNewItemCommand 
        {
            get => (ICommand)GetValue(AddNewItemCommandProperty);
            set => SetValue(AddNewItemCommandProperty, value); 
        }

        #endregion 

        #region EditItemCommand : ICommand - Редактирование элемента

        public static readonly DependencyProperty EditItemCommandProperty =
              DependencyProperty.Register(
                  nameof(EditItemCommand),
                  typeof(ICommand),
                  typeof(ItemsPanel),
                  new PropertyMetadata(default(ICommand)));
        //[Descriotion("Редактирование элемента")]
        public ICommand EditItemCommand 
        {
            get => (ICommand)GetValue(EditItemCommandProperty);
            set => SetValue(EditItemCommandProperty, value); 
        }

        #endregion       

        #region RemoveItemCommand : ICommand - Удаление элемента

        public static readonly DependencyProperty RemoveItemCommandProperty =
              DependencyProperty.Register(
                  nameof(RemoveItemCommand),
                  typeof(ICommand),
                  typeof(ItemsPanel),
                  new PropertyMetadata(default(ICommand)));
        //[Descriotion("Удаление элемента")]
        public ICommand RemoveItemCommand 
        {
            get => (ICommand)GetValue(RemoveItemCommandProperty);
            set => SetValue(RemoveItemCommandProperty, value); 
        }

        #endregion

        #region ItemSource : IEnumerable Элументы панели

        public static readonly DependencyProperty ItemSourceProperty =
              DependencyProperty.Register(
                  nameof(ItemSource),
                  typeof(IEnumerable),
                  typeof(ItemsPanel),
                  new PropertyMetadata(default(IEnumerable)));
        //[Descriotion("Элументы панели")]
        public IEnumerable ItemSource 
        {
            get => (IEnumerable)GetValue(ItemSourceProperty);
            set => SetValue(ItemSourceProperty, value); 
        }

        #endregion 
        
        #region SelectedItem : object - Выбранный элемент

        public static readonly DependencyProperty SelectedItemProperty =
              DependencyProperty.Register(
                  nameof(SelectedItem),
                  typeof(object),
                  typeof(ItemsPanel),
                  new PropertyMetadata(default(object)));

        //[Descriotion("Выбранный элемент")]
        public object SelectedItem 
        {
            get => (object)GetValue(SelectedItemProperty);
            set => SetValue(SelectedItemProperty, value); 
        }

        #endregion

        #region ItemTemplate : DataTemplate - Шаблон элемента выпадающего списка

        public static readonly DependencyProperty ItemTemplateProperty =
           DependencyProperty.Register(
               nameof(ItemTemplate),
               typeof(DataTemplate),
               typeof(ItemsPanel),
               new PropertyMetadata(default(DataTemplate)));

        //[Descriotion("Шаблон элемента выпадающего списка")]

        public DataTemplate ItemTemplate
        {
            get => (DataTemplate)GetValue(ItemTemplateProperty);
            set => SetValue(ItemTemplateProperty, value);
        }
        #endregion

        #region DisplayMemberPath : string - Имя отображаемого свойства

        public static readonly DependencyProperty DisplayMemberPathProperty =
           DependencyProperty.Register(
               nameof(DisplayMemberPath),
               typeof(string),
               typeof(ItemsPanel),
               new PropertyMetadata(default(string)));

        //[Descriotion("Имя отображаемого свойства")]

        public string DisplayMemberPath
        {
            get => (string)GetValue(DisplayMemberPathProperty);
            set => SetValue(DisplayMemberPathProperty, value);
        } 
        #endregion
        public string Title 
        { 
            get => (string)GetValue(TitleProperty);
            set => SetValue(TitleProperty,value);
        }
        public ItemsPanel() => InitializeComponent();
    }
}
