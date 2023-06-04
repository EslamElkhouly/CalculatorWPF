
using System;
using System.Windows;
using System.Windows.Controls;

namespace CalculatorWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double firstNumber = 0;
        double secondNumber = 0;
        double result = 0;
        string process="";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {

            Application.Current.Shutdown();
        }

  
        private void btnClose_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            btnClose.Content = "Close";
        }

        private void btnClose_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            btnClose.Content = "Close";
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var btn = (Button)sender;
                if (lblResult.Content.ToString() == "0")
                {
                    lblResult.Content = "";
                    lblResult.Content = lblResult.Content.ToString() + btn.Content;
                    lblCalculate.Content = lblResult.Content;
                }
                else
                {
                    if (process == "")
                    {
                        lblResult.Content = lblResult.Content.ToString() + btn.Content;
                        lblCalculate.Content = lblResult.Content;
                    }
                    else
                    {
                        lblResult.Content = lblResult.Content.ToString() + btn.Content;

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var btn = (Button)sender;
                firstNumber = Convert.ToDouble(lblResult.Content);
                process = btn.Content.ToString();
                lblCalculate.Content = lblCalculate.Content.ToString() + btn.Content;
                lblResult.Content = "";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                secondNumber = Convert.ToDouble(lblResult.Content);
                if (process == "+")
                {
                    result = firstNumber + secondNumber;
                    lblResult.Content = result;
                }
                if (process == "-")
                {
                    result = firstNumber - secondNumber;
                    lblResult.Content = result;
                }
                if (process == "*")
                {
                    result = firstNumber * secondNumber;
                    lblResult.Content = result;
                }
                if (process == "/")
                {
                    result = firstNumber / secondNumber;
                    lblResult.Content = result;
                }
                lblCalculate.Content = "";
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                lblResult.Content = "";
                lblCalculate.Content = "";
                process = "";
                firstNumber = secondNumber = result = 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void load_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                MouseDown += delegate
                {
                    DragMove();
                };
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
