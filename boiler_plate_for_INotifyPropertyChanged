using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace TestDataBindingWithGUI
{

    public class RandomBusinessObj : INotifyPropertyChanged
    {
        // boiler-plate INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
        protected bool UpdateField<T>(ref T field, T value, [CallerMemberName] string propertyName = "")
        {
            if (EqualityComparer<T>.Default.Equals(field, value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
        // end boiler-plate


        // start of actual object data/properties/methods
        private string _text;
        public string CurText
        {
            get { return _text; }
            set
            {
                if (value.Length > 5)
                {
                    UpdateField(ref _text, value);
                }
                else
                {
                    throw new Exception("string is too short:" + value);
                }
            }
        }
        
    }

}
