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
    //TODO Fix mathematical calculations with multiple numbers one after another
    //TODO Make window adjustable and allow buttons to scale based on screen size
    public partial class MainWindow : Window
    {
        //Make calculator object for calculation
        Calc calculator = new Calc();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void num0Click(object sender, RoutedEventArgs e)
        {
            //number 0 input
            checkFullNumberDisplayed(sender, e);
            if (resultBox.Text.Length == 1 && resultBox.Text[0] == '0') //Checks if only zero is in result box
            {
                return;
            }
            insertInputNumInResultBox("0");
        }

        private void num1Click(object sender, RoutedEventArgs e)
        {
            //number 1 input
            checkFullNumberDisplayed(sender, e);
            insertInputNumInResultBox("1");
        }

        private void num2Click(object sender, RoutedEventArgs e)
        {
            //number 2 input
            checkFullNumberDisplayed(sender, e);
            insertInputNumInResultBox("2");
        }

        private void num3Click(object sender, RoutedEventArgs e)
        {
            //number 3 input
            checkFullNumberDisplayed(sender, e);
            insertInputNumInResultBox("3");
        }

        private void num4Click(object sender, RoutedEventArgs e)
        {
            //number 4 input
            checkFullNumberDisplayed(sender, e);
            insertInputNumInResultBox("4");
        }

        private void num5Click(object sender, RoutedEventArgs e)
        {
            //number 5 input
            checkFullNumberDisplayed(sender, e);
            insertInputNumInResultBox("5");
        }

        private void num6Click(object sender, RoutedEventArgs e)
        {
            //number 6 input
            checkFullNumberDisplayed(sender, e);
            insertInputNumInResultBox("6");
        }

        private void num7Click(object sender, RoutedEventArgs e)
        {
            //number 7 input
            checkFullNumberDisplayed(sender, e);
            insertInputNumInResultBox("7");
        }

        private void num8Click(object sender, RoutedEventArgs e)
        {
            //number 8 input
            checkFullNumberDisplayed(sender, e);
            insertInputNumInResultBox("8");
        }

        private void num9Click(object sender, RoutedEventArgs e)
        {
            //number 9 input
            checkFullNumberDisplayed(sender, e);
            insertInputNumInResultBox("9");
        }

        public void insertInputNumInResultBox(string num)
        {
            //Insert number in result box after user inputs desired number
            try
            {
                //checkIfAnswerDisplayed();
                if (resultBox.Text.Length == 1 && (resultBox.Text)[0] == '0') //Checks if only zero is in result box
                {
                    resultBox.Text = num;
                }
                else
                {
                    resultBox.Text = resultBox.Text + num;
                }
                
            }
            catch (OverflowException)
            {
                resultBox.Text = resultBox.Text;
            }
        }

        public void deleteNum()
        {
            //Deletes numbers from screen if user wants to make changes to inputted number
            if (calculator.isNumInputFinished || calculator.isThereAnswer)
            {
                return;
            }
            else
            {
                resultBox.Text = resultBox.Text.Remove(resultBox.Text.Length - 1, 1);
                if (resultBox.Text.Length == 0)
                {
                    resultBox.Text = "0";
                }
            }
        }

        private void decimalClick(object sender, RoutedEventArgs e)
        {
            checkFullNumberDisplayed(sender, e);
            if (calculator.isNumInputFinished)
            {
                resultBox.Text = "0.";
                calculator.isNumInputFinished = false;
            }
            else if (!resultBox.Text.Contains("."))
            {
                resultBox.Text = resultBox.Text + ".";
            }
            //If result box only has ".", fix it with "0."
            if (resultBox.Text.Length == 1 && resultBox.Text[0] == '.')
            {
                resultBox.Text = "0" + resultBox.Text;
                calculator.isNumInputFinished = false;
            }
        }

        private void clearEntryClick(object sender, RoutedEventArgs e)
        {
            //'C' input
            resultBox.Text = "0";
            calculator.firstNumber = 0.0;
            calculator.firstNumberSet = false;
            calculator.secondNumber = 0.0;
            calculator.isNumInputFinished = false;
        }

        private void plusClick(object sender, RoutedEventArgs e)
        {
            if (!checkIfNumberOrNot())
            {
                return;
            }
            unsetCurrentOperator(); //Checks if user selected a different operator before and unsets it
            calculator.isPlus = true;
            calculator.isNumInputFinished = true;
            
        }

        private void minusClick(object sender, RoutedEventArgs e)
        {
            if (!checkIfNumberOrNot())
            {
                return;
            }
            unsetCurrentOperator(); //Checks if user selected a different operator before and unsets it
            calculator.isMinus = true;
            calculator.isNumInputFinished = true;
            
        }

        private void multiplyClick(object sender, RoutedEventArgs e)
        {
            if (!checkIfNumberOrNot())
            {
                return;
            }
            unsetCurrentOperator(); //Checks if user selected a different operator before and unsets it
            calculator.isMult = true;
            calculator.isNumInputFinished = true;
            
        }

        private void divideClick(object sender, RoutedEventArgs e)
        {
            if (!checkIfNumberOrNot())
            {
                return;
            }
            unsetCurrentOperator(); //Checks if user selected a different operator before and unsets it
            calculator.isDiv = true;
            calculator.isNumInputFinished = true;
            
        }

        private void exponentClick(object sender, RoutedEventArgs e)
        {
            if (!checkIfNumberOrNot())
            {
                return;
            }
            unsetCurrentOperator(); //Checks if user selected a different operator before and unsets it
            calculator.isExp = true;
            calculator.isNumInputFinished = true;
            
            
        }

        private void equalClick(object sender, RoutedEventArgs e)
        {
            try
            {
                
                //See which operator was used and perform the calculation
                if (calculator.Check(calculator.isPlus))
                {
                    calculator.secondNumber = double.Parse(resultBox.Text);
                    calculator.answer = calculator.Add();
                    showAndSetAnswer(sender, e);
                }
                else if (calculator.Check(calculator.isMinus))
                {
                    calculator.secondNumber = double.Parse(resultBox.Text);
                    calculator.answer = calculator.Subtract();
                    showAndSetAnswer(sender, e);
                }
                else if (calculator.Check(calculator.isMult))
                {
                    calculator.secondNumber = double.Parse(resultBox.Text);
                    calculator.answer = calculator.Multiply();
                    showAndSetAnswer(sender, e);
                }
                else if (calculator.Check(calculator.isDiv))
                {
                    calculator.secondNumber = double.Parse(resultBox.Text);
                    if (calculator.secondNumber == 0)
                    {
                        throw new DivideByZeroException();
                    }
                    calculator.answer = calculator.Divide();
                    showAndSetAnswer(sender, e);
                }
                else if (calculator.Check(calculator.isExp))
                {
                    calculator.secondNumber = double.Parse(resultBox.Text);
                    calculator.answer = calculator.Exponentiate();
                    showAndSetAnswer(sender, e);
                }
            } catch (DivideByZeroException)
            {
                clearForExceptions();
                resultBox.Text = "Cannot Divide by Zero";
            } catch (FormatException)
            {
                clearForExceptions();
                resultBox.Text = resultBox.Text;
            }
        }

        public void unsetCurrentOperator()
        {
            //Unset operator if it's active
            if (calculator.Check(calculator.isPlus))
            {
                calculator.isPlus = false;
            }
            else if (calculator.Check(calculator.isMinus))
            {
                calculator.isMinus = false;
            }
            else if (calculator.Check(calculator.isMult))
            {
                calculator.isMult = false;
            }
            else if (calculator.Check(calculator.isDiv))
            {
                calculator.isDiv = false;
            }
            else if (calculator.Check(calculator.isExp))
            {
                calculator.isExp = false;
            }
        }

        private void keyboardNumPress(object sender, KeyEventArgs e)
        {
            //Keyboard input
            if (e.Key == Key.NumPad0 || e.Key == Key.D0)
            {
                num0Click(sender, e);
            }
            else if (e.Key == Key.NumPad1 || e.Key == Key.D1)
            {
                num1Click(sender, e);
            }
            else if (e.Key == Key.NumPad2 || e.Key == Key.D2)
            {
                num2Click(sender, e);
            }
            else if (e.Key == Key.NumPad3 || e.Key == Key.D3)
            {
                num3Click(sender, e);
            }
            else if (e.Key == Key.NumPad4 || e.Key == Key.D4)
            {
                num4Click(sender, e);
            }
            else if (e.Key == Key.NumPad5 || e.Key == Key.D5)
            {
                num5Click(sender, e);
            }
            else if (e.Key == Key.NumPad6 || e.Key == Key.D6)
            {
                num6Click(sender, e);
            }
            else if (e.Key == Key.NumPad7 || e.Key == Key.D7)
            {
                num7Click(sender, e);
            }
            else if (e.Key == Key.NumPad8 || e.Key == Key.D8)
            {
                num8Click(sender, e);
            }
            else if (e.Key == Key.NumPad9 || e.Key == Key.D9)
            {
                num9Click(sender, e);
            }
            else if (e.Key == Key.Add)
            {
                plusClick(sender, e);
            } else if (e.Key == Key.Subtract)
            {
                minusClick(sender, e);
            }
            else if (e.Key == Key.Multiply)
            {
                multiplyClick(sender, e);
            }
            else if (e.Key == Key.Divide)
            {
                divideClick(sender, e);
            }
            else if (e.Key == Key.Enter)
            {
                equalClick(sender, e);
            }
            else if (e.Key == Key.Decimal)
            {
                decimalClick(sender, e);
            }
            else if (e.Key == Key.Back)
            {
                //Remove characters from resultbox
                deleteNum();
            }

        }

        public void showAndSetAnswer(object sender, RoutedEventArgs e)
        {
            //Show answer in result box
            calculator.isThereAnswer = true;
            calculator.isNumInputFinished = true;
            calculator.firstNumberSet = true;
            resultBox.Text = calculator.answer.ToString();
            calculator.firstNumber = calculator.answer;
            
        }

        public void checkFullNumberDisplayed(object sender, RoutedEventArgs e)
        {
            //Checks if user inputted their number after receiving an operator input, then clears result box for new number
            if (checkIfNumberOrNot())
            {
                //If there was an answer previously and a number was just inputted, it means user wants to input a whole new firstNumber and secondNumber
                if (calculator.isThereAnswer)
                {
                    unsetAll();
                    resultBox.Text = "";
                    
                }
                //If an answer wasn't previously received, check if operator was pressed checking in user completed their input
                else if (calculator.isNumInputFinished)
                {
                    setNum(sender, e);
                }
            }
            else
            {
                resultBox.Text = "";
            }
            
        }

        public void setNum(object sender, RoutedEventArgs e)
        {
            //Decides if number inputted by user is firstNumber or SecondNumber
            if (!calculator.firstNumberSet)
            {
                calculator.firstNumberSet = true;
                calculator.firstNumber = double.Parse(resultBox.Text);
                resultBox.Text = "";
            }
            else
            {
                calculator.secondNumber = double.Parse(resultBox.Text);
            }
        }
        
        public bool checkIfNumberOrNot()
        {
            //Checks if content in resultbox is an error message
            dynamic tmp = 0;
            try
            {
                tmp = double.Parse(resultBox.Text);
                return true;
            } catch (FormatException)
            {
                return false;
            }
        }

        public void unsetAll()
        {
            //Unset all booleans for firstNumber, Answer, and contents in result box
            calculator.firstNumberSet = false;
            calculator.isThereAnswer = false;
            calculator.isNumInputFinished = false;
        }

        public void clearForExceptions()
        {
            calculator.firstNumber = 0.0;
            calculator.firstNumberSet = false;
            calculator.secondNumber = 0.0;
            calculator.isThereAnswer = false;
            calculator.isNumInputFinished = false;
            unsetCurrentOperator();
        }
    }
}
