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

namespace WPF_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _operand1;
        private double _operand2;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button_Operation_Click(object sender, RoutedEventArgs e)
        {
            Button operationButton = sender as Button;

            string operation = operationButton.Name;
            string userFeedback = "";
            double answer;

            if (ValidInputs(out userFeedback))
            {
                switch (operation)
                {
                    case "button_Add":
                        answer = (_operand1 + _operand2);
                        break;

                    case "button_Subtract":
                        answer = (_operand1 - _operand2);
                        break;

                    case "button_Multiply":
                        answer = (_operand1 * _operand2);
                        break;

                    case "button_Divide":
                        answer = (_operand1 / _operand2);
                        break;

                    default:
                        answer = 0;
                        break;
                }
                label_Answer.Content = answer.ToString();
            }
            else
            {
                MessageBox.Show(userFeedback);
            }
        }
        private bool ValidInputs(out string userFeedback)
        {
            bool validInputs = true;
            userFeedback = "";

            if (!double.TryParse(textBox_Operand1.Text, out _operand1))
            {
                validInputs = false;
                userFeedback += "Operand 1 must be a double\n";
            }

            if (!double.TryParse(textBox_Operand2.Text, out _operand2))
            {
                validInputs = false;
                userFeedback += "Operand 2 must be a double\n";
            }
            return validInputs;
        }
        private void GetOperands()
        {
            double.TryParse(textBox_Operand1.Text, out _operand1);
            double.TryParse(textBox_Operand2.Text, out _operand2);
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            var blueButton = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Images/buttonblue.png")));
            var purpButton = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Images/buttonpurp.png")));
            var blueBar = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Images/bar.png")));
            var purpBar = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Images/barpurp.png")));
            var blueBackground = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Images/background.png")));
            var purpBackground = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "Images/backgroundpurp.png")));


            if ((bool)radio1.IsChecked)
            {
                _button1.ImageSource = blueButton.ImageSource;
                _button2.ImageSource = blueButton.ImageSource;
                _button3.ImageSource = blueButton.ImageSource;
                _button4.ImageSource = blueButton.ImageSource;
                _textBox1.ImageSource = blueBar.ImageSource;
                _textBox2.ImageSource = blueBar.ImageSource;
                _answer.ImageSource = blueBar.ImageSource;
                _background.ImageSource = blueBackground.ImageSource;
            }

            if((bool)radio2.IsChecked)
            {
                _button1.ImageSource = purpButton.ImageSource;
                _button2.ImageSource = purpButton.ImageSource;
                _button3.ImageSource = purpButton.ImageSource;
                _button4.ImageSource = purpButton.ImageSource;
                _textBox1.ImageSource = purpBar.ImageSource;
                _textBox2.ImageSource = purpBar.ImageSource;
                _answer.ImageSource = purpBar.ImageSource;
                _background.ImageSource = purpBackground.ImageSource;
            }
        }

    }
}
