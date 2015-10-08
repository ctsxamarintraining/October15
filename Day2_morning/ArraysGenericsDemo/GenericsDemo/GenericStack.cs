using System;
using Demo;

namespace GenericsDemo
{
    public class GenericStack<T> : IGenericStackCovariant<T>, IGenericStackContravariant<T>
    {
        protected T[] stackArr;
        protected int currentPosition;
        
        public GenericStack(int size){
            this.currentPosition = -1;
            this.stackArr = new T[size];
        }
        
        public void Push(T data){
            if(this.currentPosition >= this.stackArr.GetUpperBound(0)){
                throw new Exception("Can't take any more. Stack is full!!");
            }
            this.currentPosition = this.currentPosition + 1;
            this.stackArr[this.currentPosition] = data;
        }
        
        public T Pop(){
            if(this.currentPosition == -1){
                throw new Exception("Can't give any more. Stack is empty!!");
            }
            
            var data =  this.stackArr[this.currentPosition];
            this.currentPosition = this.currentPosition - 1;
            return data;
        }
    
    }


    public interface IGenericStackCovariant<out T>
    {
        T Pop();
    }

    public interface IGenericStackContravariant<in T>
    {
        void Push(T data);
    }
}
