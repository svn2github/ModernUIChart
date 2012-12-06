using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication.Shared
{
    public class TestPageViewModel : INotifyPropertyChanged
    {
        public TestPageViewModel()
        {
            Series = new List<SeriesData>();

            Errors = new ObservableCollection<TestClass>();
            Warnings = new ObservableCollection<TestClass>();

            Errors.Add(new TestClass() { Category = "Globalization", Number = 66 });
            Errors.Add(new TestClass() { Category = "Features", Number = 23 });
            Errors.Add(new TestClass() { Category = "Content Types", Number = 12 });
            Errors.Add(new TestClass() { Category = "Correctness", Number = 94 });
            Errors.Add(new TestClass() { Category = "Naming", Number = 45 });
            Errors.Add(new TestClass() { Category = "Best Practices", Number = 29 });

            Warnings.Add(new TestClass() { Category = "Globalization", Number = 34 });
            Warnings.Add(new TestClass() { Category = "Features", Number = 23 });
            Warnings.Add(new TestClass() { Category = "Content Types", Number = 15 });
            Warnings.Add(new TestClass() { Category = "Correctness", Number = 66 });
            Warnings.Add(new TestClass() { Category = "Naming", Number = 56 });
            Warnings.Add(new TestClass() { Category = "Best Practices", Number = 34 });

            Series.Add(new SeriesData() { DisplayName = "Errors", Items = Errors });
            Series.Add(new SeriesData() { DisplayName = "Warnings", Items = Warnings });
        }

        private object selectedItem = null;
        public object SelectedItem
        {
            get
            {
                return selectedItem;
            }
            set
            {
                selectedItem = value;
                NotifyPropertyChanged("SelectedItem");
            }
        }

        public List<SeriesData> Series
        {
            get;
            set;
        }

        public ObservableCollection<TestClass> Errors
        {
            get;
            set;
        }

        public ObservableCollection<TestClass> Warnings
        {
            get;
            set;
        }

        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
