using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public Unicorn TestUnicorn
        {
            get; set;
        }

        public List<Unicorn> TestUnicornList { get; set; }


        
        public string UnicornName
        {
            get
            {
                return "Name: " + TestUnicorn.Name;
            }
        }
        
        public string UnicornRGBColor
        {
            get
            {
                return "Color: " + TestUnicorn.RGBColor;
            }
        }
        
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            TestUnicorn = new Unicorn("Annegret", new DateTime(2009, 11, 9), "469872", "Hallo I bims Annegret. Bobs und vagene ich bin fett hihi");

            TestUnicornList = new List<Unicorn>();
            TestUnicornList.Add(new Unicorn("Annegret", new DateTime(2009, 11, 9), "469872", "Hallo I bims Annegret. Bobs und vagene ich bin fett hihi"));
            TestUnicornList.Add(new Unicorn("Aaron", new DateTime(1900, 5, 3), "123456", "Ich bin so dumm"));
            for (int i = 0; i < TestUnicornList.Count; i++)
            {
                NamesBox.Items.Add(TestUnicornList.ElementAt(i).Name);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(String propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
