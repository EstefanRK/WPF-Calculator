using System.Data;
using System.Linq.Expressions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFTutorial
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public bool OperatorExists = true;
        public string number = "";
        public string Operator;
        public MainWindow()
        {
            InitializeComponent();
            infobox.Text = "0";
        }

        private void Button_7_Click(object sender, RoutedEventArgs e)
        {
            number = number + 7.ToString();
            infobox.Text = number;
            OperatorExists = false;
        }
        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            if (number != "")
            {
                number = number + 0.ToString();
                infobox.Text = number;
                OperatorExists = false;
            }
        }

        private void Button_3_Click(object sender, RoutedEventArgs e)
        {
            number = number + 3.ToString();
            infobox.Text = number;
            OperatorExists = false;
        }

        private void Button_2_Click(object sender, RoutedEventArgs e)
        {
            number = number + 2.ToString();
            infobox.Text = number;
            OperatorExists = false;
        }

        private void Button_1_Click(object sender, RoutedEventArgs e)
        {
            number = number + 1.ToString();
            infobox.Text = number;
            OperatorExists = false;
        }

        private void Button_6_Click(object sender, RoutedEventArgs e)
        {
            number = number + 6.ToString();
            infobox.Text = number;
            OperatorExists = false;
        }

        private void Button_5_Click(object sender, RoutedEventArgs e)
        {
            number = number + 5.ToString();
            infobox.Text = number;
            OperatorExists = false;
        }

        private void Button_4_Click(object sender, RoutedEventArgs e)
        {
            number = number + 4.ToString();
            infobox.Text = number;
            OperatorExists = false;
        }

        private void Button_9_Click(object sender, RoutedEventArgs e)
        {
            number = number + 9.ToString();
            infobox.Text = number;
            OperatorExists = false;
        }

        private void Button_8_Click(object sender, RoutedEventArgs e)
        {
            number = number + 8.ToString();
            infobox.Text = number;
            OperatorExists = false;
        }

        private void Button_calculate_Click(object sender, RoutedEventArgs e)
        {
            if (!number.Contains("/0"))
            {
                if (OperatorExists)
                {
                    number = number.Substring(0, number.Length - 1);
                }


                // Create a DataTable to use its Compute method
                DataTable table = new DataTable();

                // Use the Compute method to evaluate the expression
                object result = table.Compute(number, "");

                // Convert the result to an integer
                int finalResult = Convert.ToInt32(result);

                infobox.Text = finalResult.ToString();
                number = finalResult.ToString();
                OperatorExists = false;

                if (finalResult == 0)
                {
                    number = "";
                }
            }
            else
            {
                infobox.Text = "Undefined";
            }
        }

        private void Button_addition_Click(object sender, RoutedEventArgs e)
        {
            if (!OperatorExists)
            {
                number = number + "+";
                OperatorExists = true;
                infobox.Text = number;
            }
        }

        private void Button_C_Click(object sender, RoutedEventArgs e)
        {
            number = "";
            infobox.Text = "0";
        }

        private void Button_division_Click(object sender, RoutedEventArgs e)
        {
            if (!OperatorExists)
            {
                number = number + "/";
                OperatorExists = true;
                infobox.Text = number;
            }
        }

        private void Button_subtraction_Click(object sender, RoutedEventArgs e)
        {
            if (!OperatorExists)
            {
                number = number + "-";
                OperatorExists = true;
                infobox.Text = number;
            }
        }

        private void Button_multiplication_Click(object sender, RoutedEventArgs e)
        {
            if (!OperatorExists)
            {
                number = number + "*";
                OperatorExists = true;
                infobox.Text = number;
            }
        }
    }
}