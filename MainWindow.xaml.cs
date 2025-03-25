using System.Linq;
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

namespace Statistika
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Calculator calculator;
        public MainWindow()
        {
            InitializeComponent();
            
        }

       

        private void biggestNumberTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            calculator = new Calculator(inputForNumbers.Text);
            sumTextBox.Text = calculator.GetSum().ToString();
            avgTextBox.Text = calculator.GetAverage().ToString();
            lowestNumberTextBox.Text = calculator.GetMin().ToString();
            biggestNumberTextBox.Text = calculator.GetMax().ToString();
            orderedTextBox.Text = calculator.GetOrderedStringAsc();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Pokud ještě nebyl vytvořen kalkulátor, vytvoř ho
            if (calculator == null)
            {
                if (string.IsNullOrWhiteSpace(inputForNumbers.Text)) return;
                calculator = new Calculator(inputForNumbers.Text);
            }

            if (comboBox.SelectedIndex == 0)
            {
                orderedTextBox.Text = calculator.GetOrderedStringAsc();
            }
            else if (comboBox.SelectedIndex == 1)
            {
                orderedTextBox.Text = calculator.GetOrderedStringDsc();
            }
        }

        private void inputForNumbers_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}