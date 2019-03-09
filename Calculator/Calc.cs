using System;

namespace Calculator
{
    public class Calc
    {
        public long firstNumber, secondNumber;
        public bool firstNumberSet, secondNumberSet, isThereAnswer;
        public bool isPlus, isMinus, isMult, isDiv, isExp;

        public Calc()
        {
            firstNumber = 0;
            secondNumber = 0;
            firstNumberSet = false;
            secondNumberSet = false;
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
            firstNumberSet = false;
            secondNumberSet = false;
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
            long origNum = firstNumber;
            for (int i = 1; i < secondNumber; i++)
            {
                firstNumber *= origNum;
            }

            return firstNumber;
        }

        public void Clear()
        {
            firstNumber = 0;
            secondNumber = 0;
        }

    }
}
