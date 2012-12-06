using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Shared
{
    public class SeriesData
    {
        public string DisplayName { get; set; }

        public string Description { get; set; }

        public ObservableCollection<TestClass> Items { get; set; }
    }

    public class TestClass : INotifyPropertyChanged
    {
        public string Category { get; set; }

        private float _number = 0;
        public float Number 
        {
            get
            {
                return _number;
            }
            set
            {
                _number = value;
                if (PropertyChanged != null)
                {
                    this.PropertyChanged(this, new PropertyChangedEventArgs("Number"));
                }
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
