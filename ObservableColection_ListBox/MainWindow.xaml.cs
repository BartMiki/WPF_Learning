using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace ObservableColection_ListBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<PersonData> Persons { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Persons = new ObservableCollection<PersonData>();

            Persons.Add(new PersonData(){Age = 20, Email = "bartmiki@wp.pl", Name = "Bartek"});
            Persons.Add(new PersonData() { Age = 32, Email = "robco@wp.pl", Name = "Robert" });

            ListaImion.ItemsSource = Persons;
        }

        private void AddNameToList_OnClick(object sender, RoutedEventArgs e)
        {
            Persons.Add(new PersonData(){
                Name = NameToAdd.Text,
                Age = int.Parse(AgeToAdd.Text),
                Email = EmailToAdd.Text
            });
            NameToAdd.Text = "";
            AgeToAdd.Text = "";
            EmailToAdd.Text = "";
        }

        private void RemoveSelected_OnClick(object sender, RoutedEventArgs e)
        {
            int index = ListaImion.SelectedIndex;
            if(index>=0)
            {
                Persons.RemoveAt(index);
            }
        }
    }
}
