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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Make calculator object for calculation
        Calc calculator = new Calc();

        public MainWindow()
        {
            InitializeComponent();
        }

        class Calc
        {
            private long firstNumber, secondNumber;
            private bool isThereAnswer;
            private bool isPlus, isMinus, isMult, isDiv, isExp;

            public Calc()
            {
                firstNumber = 0;
                secondNumber = 0;
                isThereAnswer = false;
                isPlus = false;
                isMinus = false;
                isMult = false;
                isDiv = false;
                isExp = false;
            }

            public Calc(long firstNumber, long secondNumber)
            {
                this.firstNumber = firstNumber;
                this.secondNumber = secondNumber;
                isThereAnswer = false;
                isPlus = false;
                isMinus = false;
                isMult = false;
                isDiv = false;
                isExp = false;
            }

            public void SetFirstNumber(long num)
            {
                firstNumber = num;
            }

            public void SetSecondNumber(long num)
            {
                secondNumber = num;
            }

            public bool Check(bool arg)
            {
                if (arg)
                {
                    return true;
                }

                return false;
            }

            public void setIsThereAnswer()
            {
                isThereAnswer = true;
            }

            public void unsetIsThereAnswer()
            {
                isThereAnswer = false;
            }

            public bool getIsThereAnswer()
            {
                return isThereAnswer;
            }
          
            public void setPlus()
            {
                isPlus = true;
            }

            public void unsetPlus()
            {
                isPlus = false;
            }

            public bool getIsPlus()
            {
                return isPlus;
            }

            public void setMinus()
            {
                isMinus = true;
            }

            public void unsetMinus()
            {
                isMinus = false;
            }

            public bool getIsMinus()
            {
                return isMinus;
            }

            public void setMult()
            {
                isMult = true;
            }

            public void unsetMult()
            {
                isMult = false;
            }

            public bool getIsMult()
            {
                return isMult;
            }

            public void setDiv()
            {
                isDiv = true;
            }

            public void unsetDiv()
            {
                isDiv = false;
            }

            public bool getIsDiv()
            {
                return isDiv;
            }

            public void setExp()
            {
                isExp = true;
            }

            public void unsetExp()
            {
                isExp = false;
            }

            public bool getIsExp()
            {
                return isExp;
            }

            public long Add()
            {
                return firstNumber + secondNumber;
            }

            public long Subtract()
            {
                return firstNumber - secondNumber;
            }

            public long Multiply()
            {
                return firstNumber * secondNumber;
            }

            public long Divide()
            {
                return firstNumber / secondNumber;
            }

            public long Exponentiate()
            {
                for (int i = 1; i < secondNumber; i++)
                {
                    firstNumber *= firstNumber;
                }

                return firstNumber;
            }

            public void Clear()
            {
                firstNumber = 0;
                secondNumber = 0;
            }

        }

        private void num0Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "0";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }

        }

        private void num1Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "1";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num2Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "2";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            } catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num3Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "3";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num4Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "4";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num5Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "5";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num6Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "6";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num7Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "7";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num8Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "8";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void num9Click(object sender, RoutedEventArgs e)
        {
            //Checks to is if answer was just displayed, and erase it if it was
            if (calculator.getIsThereAnswer())
            {
                resultBox.Text = "0";
                calculator.unsetIsThereAnswer();
            }

            try
            {
                string newNumStr = resultBox.Text + "9";
                long newNum = long.Parse(newNumStr);
                resultBox.Text = newNum.ToString();
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        private void clearEntryClick(object sender, RoutedEventArgs e)
        {
            resultBox.Text = "0";
        }

        private void plusClick(object sender, RoutedEventArgs e)
        {
            calculator.SetFirstNumber(long.Parse(resultBox.Text));
            calculator.setPlus();
            resultBox.Text = "0";
            
        }

        private void equalClick(object sender, RoutedEventArgs e)
        {
            try
            {
                if (calculator.Check(calculator.getIsPlus()))
                {
                    calculator.SetSecondNumber(long.Parse(resultBox.Text));
                    long finalNum = calculator.Add();
                    calculator.setIsThereAnswer();
                    resultBox.Text = finalNum.ToString();
                }
                else if (calculator.Check(calculator.getIsMinus()))
                {
                    calculator.SetSecondNumber(long.Parse(resultBox.Text));
                    long finalNum = calculator.Subtract();
                    calculator.setIsThereAnswer();
                    resultBox.Text = finalNum.ToString();
                }
                else if (calculator.Check(calculator.getIsMult()))
                {
                    calculator.SetSecondNumber(long.Parse(resultBox.Text));
                    long finalNum = calculator.Multiply();
                    calculator.setIsThereAnswer();
                    resultBox.Text = finalNum.ToString();
                }
                else if (calculator.Check(calculator.getIsDiv()))
                {
                    calculator.SetSecondNumber(long.Parse(resultBox.Text));
                    long finalNum = calculator.Divide();
                    calculator.setIsThereAnswer();
                    resultBox.Text = finalNum.ToString();
                }
                else if (calculator.Check(calculator.getIsExp()))
                {
                    calculator.SetSecondNumber(long.Parse(resultBox.Text));
                    long finalNum = calculator.Exponentiate();
                    calculator.setIsThereAnswer();
                    resultBox.Text = finalNum.ToString();
                }
            } catch (DivideByZeroException)
            {
                resultBox.Text = "Cannot Divide by Zero";
                calculator.setIsThereAnswer();
            }
        }
    }
}
