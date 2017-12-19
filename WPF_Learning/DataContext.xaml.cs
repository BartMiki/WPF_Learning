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
    /// Interaction logic for EventyDelegatyWindow.xaml
    /// </summary>
    public partial class DataContext : Window
    {
        private InkEditingModes editingModes = new InkEditingModes();

        public DataContext()
        {
            InitializeComponent();
            this.DataContext = editingModes;
        }

        private void ButtonSelect_Click(object sender, RoutedEventArgs e)
        {
            editingModes.EditingMode = InkCanvasEditingMode.Select;
        }

        private void ButtonDraw_Click(object sender, RoutedEventArgs e)
        {
            editingModes.EditingMode = InkCanvasEditingMode.Ink;
        }
    }
}
