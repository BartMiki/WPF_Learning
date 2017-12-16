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
    /// Interaction logic for CirclesWindow.xaml
    /// </summary>
    public partial class CirclesWindow : Window
    {
        public CirclesWindow()
        {
            InitializeComponent();
        }

        private void Confirm_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double radious = Convert.ToDouble(radiousInput.Text);
                double centerX = canva.Width / 2;
                double centerY = canva.Height / 2;
                double x;
                double y;
                int vertexNumber = Convert.ToInt32(vertexInput.Text);
                double height, width;
                height = width = 20d;
                List<Ellipse> ellipseList = new List<Ellipse>();
                for (int i = 0; i < vertexNumber; i++)
                {
                    var ellipse = new Ellipse
                    {
                        Height = height,
                        Width = width,
                        Fill = Brushes.Black,
                    };
                    ellipseList.Add(ellipse);
                }
                foreach (var i in ellipseList)
                {
                    canva.Children.Add(i);
                }
                for (int i = 0; i < vertexNumber; i++)
                {
                    x = radious * Math.Cos(2 * Math.PI * i / vertexNumber);
                    x += (centerX - width);
                    y = radious * Math.Sin(2 * Math.PI * i / vertexNumber);
                    y += (centerY - height);
                    Canvas.SetLeft(ellipseList[i], x);
                    Canvas.SetTop(ellipseList[i], y);
                }
            }
            catch(Exception)
            {
                radiousInput.Text = "ERROR";
                vertexInput.Text = "ERROR";
            }
        }

        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            canva.Children.Clear();
            vertexInput.Text = "";
            radiousInput.Text = "";
        }
    }
}
