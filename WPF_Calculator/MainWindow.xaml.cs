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
            double answer = 0;
            bool divByZero = false;

            if (ValidInputs(out string userFeedback))
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
                        if(_operand2 == 0)
                        {
                            divByZero = true;
                        }
                        answer = (_operand1 / _operand2);

                        break;

                    default:
                        answer = 0;
                        break;
                }
                if(!divByZero)
                {
                    label_Answer.Content = answer.ToString();
                }
                else
                {
                    label_Answer.Content = "Can't Divide by 0";
                }
                
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

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(IsLoaded)
            {
                UpdateTheme();
            }
            
        }

        private void UpdateTheme()
        {
            if ((bool)radio1.IsChecked)
            {
                BlueTheme();
            }

            else if ((bool)radio2.IsChecked)
            {
                PurpleTheme();
            }
        }
        private void PurpleTheme()
        {
            GetImageSource("Images/buttonpurp.png", "Images/barpurp.png", "Images/backgroundpurp.png", out ImageBrush purpButton, out ImageBrush purpBar, out ImageBrush purpBackground);
            SetImageSrc(purpButton, purpBar, purpBackground);
        }
        private void BlueTheme()
        {
            GetImageSource("Images/buttonblue.png", "Images/bar.png", "Images/background.png", out ImageBrush blueButton, out ImageBrush blueBar, out ImageBrush blueBackground);
            SetImageSrc(blueButton, blueBar, blueBackground);
        }
        private void GetImageSource(string imagePathOne, string imagePathTwo, string imagePathThree, out ImageBrush imageButton, out ImageBrush imageBar, out ImageBrush imageBackground)
        {
            imageButton = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), $"{imagePathOne}")));
            imageBar = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), $"{imagePathTwo}")));
            imageBackground = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), $"{imagePathThree}")));
        }
        private void SetImageSrc(ImageBrush imageButton, ImageBrush imageBar, ImageBrush imageBackground)
        {
            _button1.ImageSource = imageButton.ImageSource;
            _button2.ImageSource = imageButton.ImageSource;
            _button3.ImageSource = imageButton.ImageSource;
            _button4.ImageSource = imageButton.ImageSource;
            _help.ImageSource = imageButton.ImageSource;
            _exit.ImageSource = imageButton.ImageSource;
            _textBox1.ImageSource = imageBar.ImageSource;
            _textBox2.ImageSource = imageBar.ImageSource;
            _answer.ImageSource = imageBar.ImageSource;
            _radio1.ImageSource = imageBar.ImageSource;
            _radio2.ImageSource = imageBar.ImageSource;
            _background.ImageSource = imageBackground.ImageSource;
        }

        private void Button_HelpButton_Click(object sender, RoutedEventArgs e)
        {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.ShowDialog();
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
