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
    /// Interaction logic for CalculatorWindow.xaml
    /// </summary>
    public partial class CalculatorWindow : Window
    {
        private enum Operand { Div, Multi, Sub, Add, None }

        public double Val1 { get; set; }
        public double Val2 { get; set; }
        private bool dotClicked;
        private bool afterOp;
        private Operand op;

        public CalculatorWindow()
        {
            InitializeComponent();
            dotClicked = false;
            op = Operand.None;
            afterOp = false;
            this.TextBox.Text = "";
            this.OperationField.Text = "";
        }

        private void Bttn_7_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox.Text += 7;
            this.OperationField.Text += 7;
        }

        private void Bttn_8_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox.Text += 8;
            this.OperationField.Text += 8;
        }

        private void Bttn_9_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox.Text += 9;
            this.OperationField.Text += 9;
        }

        private void Bttn_4_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox.Text += 4;
            this.OperationField.Text += 4;
        }

        private void Bttn_5_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox.Text += 5;
            this.OperationField.Text += 5;
        }

        private void Bttn_6_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox.Text += 6;
            this.OperationField.Text += 6;
        }

        private void Bttn_1_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox.Text += 1;
            this.OperationField.Text += 1;
        }

        private void Bttn_2_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox.Text += 2;
            this.OperationField.Text += 2;
        }

        private void Bttn_3_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox.Text += 3;
            this.OperationField.Text += 3;
        }

        private void Bttn_0_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox.Text += 0;
            this.OperationField.Text += 0;
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            if (!dotClicked)
            {
                this.TextBox.Text += ".";
                this.OperationField.Text += ".";
                dotClicked = true;
            }
        }

        private void Div_Click(object sender, RoutedEventArgs e)
        {
            if(!afterOp)
            {
                string val = this.TextBox.Text;
                if (val[val.Length - 1] == '.')
                    val += 0;

                dotClicked = false;
                Val1 = Convert.ToDouble(val, System.Globalization.CultureInfo.InvariantCulture);
                op = Operand.Div;
                this.TextBox.Text = "";
                this.OperationField.Text += " / ";
                afterOp = true;
            }
        }

        private void Multi_Click(object sender, RoutedEventArgs e)
        {
            if (!afterOp)
            {
                string val = this.TextBox.Text;
                if (val[val.Length - 1] == '.')
                    val += 0;

                dotClicked = false;
                Val1 = Convert.ToDouble(val, System.Globalization.CultureInfo.InvariantCulture);
                op = Operand.Multi;
                this.TextBox.Text = "";
                this.OperationField.Text += " * ";
                afterOp = true;
            }
        }

        private void Sub_Click(object sender, RoutedEventArgs e)
        {
            if (!afterOp)
            {
                string val = this.TextBox.Text;
                if (val[val.Length - 1] == '.')
                    val += 0;

                dotClicked = false;
                Val1 = Convert.ToDouble(val, System.Globalization.CultureInfo.InvariantCulture);
                op = Operand.Sub;
                this.TextBox.Text = "";
                this.OperationField.Text += " - ";
                afterOp = true;
            }
        }

        private void Plus_Click(object sender, RoutedEventArgs e)
        {
            if (!afterOp)
            {
                string val = this.TextBox.Text;
                if (val[val.Length - 1] == '.')
                    val += 0;

                dotClicked = false;
                Val1 = Convert.ToDouble(val, System.Globalization.CultureInfo.InvariantCulture);
                op = Operand.Add;
                this.TextBox.Text = "";
                this.OperationField.Text += " + ";
                afterOp = true;
            }
        }

        private void Equal_Click(object sender, RoutedEventArgs e)
        {
            string val = this.TextBox.Text;
            if (val[val.Length - 1] == '.')
                val += 0;

            Val2 = Convert.ToDouble(val, System.Globalization.CultureInfo.InvariantCulture);

            switch (op)
            {
                case Operand.Add:
                    this.TextBox.Text = (Val1 + Val2).ToString();
                    break;
                case Operand.Sub:
                    this.TextBox.Text = (Val1 - Val2).ToString();
                    break;
                case Operand.Multi:
                    this.TextBox.Text = (Val1 * Val2).ToString();
                    break;
                case Operand.Div:
                    this.TextBox.Text = (Val1 / Val2).ToString();
                    break;
                case Operand.None:
                    this.TextBox.Text = Val1.ToString();
                    break;
            }
        }

        private void CE_Click(object sender, RoutedEventArgs e)
        {
            this.TextBox.Text = "";
            this.OperationField.Text = "";
            afterOp = false;
        }

    }
}
