using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.ComponentModel;

namespace WPF_Learning
{
    class InkEditingModes : INotifyPropertyChanged
    {

        public InkEditingModes()
        {
            _EditingMode = InkCanvasEditingMode.Ink;
        }

        private InkCanvasEditingMode _EditingMode;
        public InkCanvasEditingMode EditingMode
        {
            get
            {
                return _EditingMode;
            }
            set
            {            
                _EditingMode = value;
                //do listy eventów dodaje nowy event tego obiektu i obiekt z nazwą properties
                EventThatPropertyChanged("EditingMode");
            }
        }

        public void EventThatPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
