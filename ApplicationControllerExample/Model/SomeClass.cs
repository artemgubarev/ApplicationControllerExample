using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationControllerExample.Model
{
    public class SomeClass : INotifyPropertyChanged
    {

        private string _someField;

        public string SomeField
        {
            get { return _someField; }
            set 
            {
                if (_someField != value)
                {
                    _someField = value;
                    OnPropertyChanged(nameof(SomeField));   
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
