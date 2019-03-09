using System;

namespace Calculator
{
    public class Calc
    {
        public long firstNumber, secondNumber, answer;
        public bool firstNumberSet, secondNumberSet, isThereFullNumber, isThereAnswer;
        public bool isPlus, isMinus, isMult, isDiv, isExp;

        public Calc()
        {
            firstNumber = 0;
            secondNumber = 0;
            answer = 0;
            firstNumberSet = false;
            secondNumberSet = false;
            isThereFullNumber = false;
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
