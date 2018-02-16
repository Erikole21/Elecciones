using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Elecciones.ViewModels
{
    /// <summary>
    /// ViewModelBase    
    /// </summary>
    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
