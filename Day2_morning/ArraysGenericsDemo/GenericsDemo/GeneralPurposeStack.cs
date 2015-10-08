using System;
namespace Demo
{
    public class GeneralPurposeStack
    {
        private object[] stackArr;
        private int currentPosition;

        public GeneralPurposeStack(int size)
        {
            this.stackArr = new object[size];
            this.currentPosition = -1;
        }

        public void Push(object data)
        {
            if (this.currentPosition >= this.stackArr.GetUpperBound(0))
            {
                throw new Exception("Can't take any more. Stack is full!!");
            }
            this.currentPosition = this.currentPosition + 1;
            this.stackArr[this.currentPosition] = data;
        }

        public object Pop()
        {
            if (this.currentPosition == -1)
            {
                throw new Exception("Can't give any more. Stack is empty!!");
            }

            var data = this.stackArr[this.currentPosition];
            this.currentPosition = this.currentPosition - 1;
            return data;
        }
    }
}