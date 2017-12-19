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
        public MainWindow()
        {
            InitializeComponent();
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

        private void Circle_Draw_Click(object sender, RoutedEventArgs e)
        {
            var cw = new CirclesWindow();
            cw.Show();
        }

        private void Eventy_i_delegaty_Click(object sender, RoutedEventArgs e)
        {
            var delegatyWin = new EventyDelegatyWindow();
            delegatyWin.Show();
        }

        private void ButtonToChangeBindings_Click(object sender, RoutedEventArgs e)
        {
            writeToIt.Text = DateTime.Now.ToLongTimeString();
        }

        private void ButtonToClearBindings_Click(object sender, RoutedEventArgs e)
        {
            writeToIt.Text = "";
        }
    }
}
