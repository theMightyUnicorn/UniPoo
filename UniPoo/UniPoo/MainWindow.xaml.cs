using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UniPoo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private Unicorn _selectedUnicorn;
        public Unicorn SelectedUnicorn
        {
            get
            {
                return this._selectedUnicorn;
            }
            set {
                Trace.WriteLine("New Unicorn Selected " + value.Name);
                this._selectedUnicorn = value;
                OnPropertyChanged("SelectedUnicorn");

            }
        }

        public List<Unicorn> TestUnicornList { get; set; }

        
        public MainWindow()
        {
            Trace.WriteLine("Swag");
            InitializeComponent();
            DataContext = this;

            TestUnicornList = new List<Unicorn>();
            TestUnicornList.Add(new Unicorn("Aaron", new DateTime(1900, 5, 3), "123456", "Ich bin so dumm"));
            TestUnicornList.Add(new Unicorn("Annegret", new DateTime(2009, 11, 9), "469872", "Hallo I bims Annegret. Bobs und vagene ich bin fett hihi"));

            SelectedUnicorn = TestUnicornList[1];
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(String propertyName)
        {
            Console.WriteLine("SWAG");
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
