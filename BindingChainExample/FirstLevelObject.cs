using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfExample.Annotations;

namespace WpfExample.BindingChainExample
{
    public class FirstLevelObject : ChainObjectBase
    {
        private SecondLevelObject internalObject;
        public SecondLevelObject InternalObject
        {
            get { return internalObject; }
            set
            {
                if (internalObject == value)
                    return;

                internalObject = value;
                base.OnPropertyChanged(MemberName.Of(() => this.InternalObject));
            }
        }
    }
}
