using System;

namespace Calculator
{
    public class Calc
    {
        public double firstNumber, secondNumber, answer;
        public bool firstNumberSet, secondNumberSet, isNumInputFinished, isThereAnswer;
        public bool isPlus, isMinus, isMult, isDiv, isExp;

        public Calc()
        {
            firstNumber = 0.0;
            secondNumber = 0.0;
            answer = 0.0;
            firstNumberSet = false;
            secondNumberSet = false;
            isNumInputFinished = false;
            isThereAnswer = false;
            isPlus = false;
            isMinus = false;
            isMult = false;
            isDiv = false;
            isExp = false;
        }

        public bool Check(bool arg)
        {
            if (arg)
            {
                return true;
            }

            return false;
        }

        public double Add()
        {
            return firstNumber + secondNumber;
        }

        public double Subtract()
        {
            return firstNumber - secondNumber;
        }

        public double Multiply()
        {
            return firstNumber * secondNumber;
        }

        public double Divide()
        {
            return firstNumber / secondNumber;
        }

        public double Exponentiate()
        {
            double origNum = firstNumber;
            for (int i = 1; i < secondNumber; i++)
            {
                firstNumber *= origNum;
            }

            return firstNumber;
        }
    }
}
