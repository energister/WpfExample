namespace WpfExample.BindingChainExample
{
    public class SecondLevelObject : ChainObjectBase
    {
        private string text;
        public string Text
        {
            get { return text; }
            set
            {
                if (text == value)
                    return;
                
                text = value;
                base.OnPropertyChanged(MemberName.Of(() => this.Text));
            }
        }
    }
}
