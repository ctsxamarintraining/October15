using System;
namespace Demo
{
    public class IntegerStack
    {
        private int[] stackArr;
        private int currentPosition;

        public IntegerStack(int size)
        {
            this.stackArr = new int[size];
            this.currentPosition = -1;
        }

        public void Push(int number)
        {
            if (this.currentPosition >= this.stackArr.GetUpperBound(0))
            {
                throw new Exception("Can't take any more. Stack is full!!");
            }
            this.currentPosition = this.currentPosition + 1;
            this.stackArr[this.currentPosition] = number;
        }

        public int Pop()
        {
            if (this.currentPosition == -1)
            {
                throw new Exception("Can't give any more. Stack is empty!!");
            }

            var number = this.stackArr[this.currentPosition];
            this.currentPosition = this.currentPosition - 1;
            return number;
        }
    }
}