using System;
using System.Collections.Generic;
namespace Intermediate
{
    public class Stack<T>
    {
        readonly private List<T> stackList = new List<T>();
        int stackCount;
        public void Push(T element)
        {
            if(element == null) 
            {
                throw new InvalidOperationException("value can not be null");
                return;
            }
            stackList.Add(element);
            stackCount++;
        }

        public T Pop()
        {
            if(stackList.Count <= 0) 
            {
                 throw new InvalidOperationException("value can not be null");
                
            }
            int index = stackList.Count - 1;
            T popedValue = stackList[stackList.Count - 1];
            stackList.Remove(stackList[index]);
            stackCount--;
            return popedValue;
        }

        public void Clear()
        {
            stackList.Clear();
        }
        public int GetStackElementsCount()
        {
            return stackList.Count;
        }
    }
}