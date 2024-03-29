﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using WpfExample.Annotations;

namespace WpfExample.BindingChainExample
{
    public abstract class ChainObjectBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
