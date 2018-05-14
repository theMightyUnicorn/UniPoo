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
using UniPoo.DAO;

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
            set
            {
                //Trace.WriteLine("New Unicorn Selected " + value.Name);
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

            TestUnicornList = UnicornDAO.Instance.GetUnicornList();

            SelectedUnicorn = TestUnicornList[1];
            
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(String propertyName)
        {
            Console.WriteLine("SWAG");
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private void Button_Click_Create(object sender, RoutedEventArgs e)
        {
            Trace.WriteLine("Hihihi ich hab den knopf gedrückt");
            //Unicorn swaggyUnicorn = new Unicorn("Robert", new DateTime(2010, 1, 8), "666666", "Ich bin so ein geiler Hengst");
            //TestUnicornList.Add(swaggyUnicorn);
            //NamesBox.Items.Refresh();
            //SelectedUnicorn = swaggyUnicorn;
            //OnPropertyChanged("TestUnicornList"); hat keine auswirkungen whatever

            Unicorn uniporn = new Unicorn(null, new DateTime(), null, null);
            TestUnicornList.Add(uniporn);
            NamesBox.Items.Refresh();
            SelectedUnicorn = uniporn;
            Button_Click_Edit(null, null);
        }
        private void Button_Click_Delete(object sender, RoutedEventArgs e)
        {
            TestUnicornList.Remove(SelectedUnicorn);
            NamesBox.Items.Refresh();
        }
        private void Button_Click_Edit(object sender, RoutedEventArgs e)
        {
            if (EditButton.Content.ToString().Equals("Edit"))
            {
                NametxtBox.IsReadOnly = false;
                RGBColortxtBox.IsReadOnly = false;
                DescriptiontxtBox.IsReadOnly = false;
              
                EditButton.Content = "Save";
            }
            else if (EditButton.Content.ToString().Equals("Save"))
            {
                NametxtBox.IsReadOnly = true;
                RGBColortxtBox.IsReadOnly = true;
                DescriptiontxtBox.IsReadOnly = true;
                EditButton.Content = "Edit";
            }

        }
    }
}
