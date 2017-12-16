using System;
using System.Collections.Generic;
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

namespace WPF_Learning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int Counter { get; private set; }

        public MainWindow()
        {
            InitializeComponent();
            Counter = 1;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            label_new.Content = Counter++;
            textBlock.Text += "Wywołał mnie: " + sender.ToString() +"\n";
        }

        private void Kalkulator_button_Click(object sender, RoutedEventArgs e)
        {
            var calc = new CalculatorWindow();
            calc.Show();
        }

        private void Stac_Wrap_Panel_Button_Click(object sender, RoutedEventArgs e)
        {
            var stacWarpWin = new Stack_Wrap_Window();
            stacWarpWin.Show();
        }
    }
}
