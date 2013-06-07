using System.Windows.Controls;

namespace WpfExample.BindingChainExample
{
    public partial class BindingChainExampleControl : UserControl
    {
        public FirstLevelObject DataSource { get; set; }

        public BindingChainExampleControl()
        {
            // shoud be assigned before InitializeComponent
            // because initial value is null
            // and BindingChainExampleControl desn't implement INotifyPropertyChanged
            // so noone will know that value of DataSource has been changed
            DataSource = new FirstLevelObject();
            DataSource.PropertyChanged += (sender, args) => OnInternalObjectChanged();

            InitializeComponent();
            
            OnInternalObjectChanged();
        }

        private void OnInternalObjectChanged()
        {
            if (DataSource.InternalObject == null)
            {
                ActionButton.Content = "Assign";
            }
            else
            {
                ActionButton.Content = "Set to null";
            }
        }

        private void ActionButtonClick(object sender, System.Windows.RoutedEventArgs e)
        {
            if (DataSource.InternalObject == null)
            {
                DataSource.InternalObject = new SecondLevelObject
                    {
                        Text = "test text"
                    };
            }
            else
            {
                DataSource.InternalObject = null;
            }
        }
    }
}
