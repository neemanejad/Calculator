using System;

namespace Calculator
{
    public class Calc
    {
        private long firstNumber, secondNumber;
        private bool firstNumberSet, secondNumberSet, isThereAnswer;
        private bool isPlus, isMinus, isMult, isDiv, isExp;

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

        public void setFirstNumberSet()
        {
            firstNumberSet = true;
        }

        public void unsetFirstNumberSet()
        {
            firstNumberSet = false;
        }

        public bool getFirstNumberSet()
        {
            return firstNumberSet;
        }

        public void setSecondsNumberSet()
        {
            firstNumberSet = true;
        }

        public void unsetSecondNumberSet()
        {
            firstNumberSet = false;
        }
        public bool getSecondNumberSet()
        {
            return secondNumberSet;
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
