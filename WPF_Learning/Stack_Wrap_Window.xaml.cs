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
using System.Windows.Shapes;

namespace WPF_Learning
{
    /// <summary>
    /// Interaction logic for Stack_Wrap_Window.xaml
    /// </summary>
    public partial class Stack_Wrap_Window : Window
    {
        public Stack_Wrap_Window()
        {
            InitializeComponent();
        }

        private void setToFill_Checked(object sender, RoutedEventArgs e)
        {
            if(myDock != null)
                myDock.LastChildFill = true;
        }

        private void setToFill_Unchecked(object sender, RoutedEventArgs e)
        {
            myDock.LastChildFill = false;
        }
    }
}
