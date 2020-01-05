using System;
using System.Collections.Generic;

namespace SampleStack
{
    public class SampleStack<T> : IStack<T>
    {
        private List<T> stackList;
        public SampleStack()
        {
            stackList = new List<T>();
        }
        public bool IsEmpty()
        {
            return (stackList.Count == 0);
        }

        public void Push(T o)
        {
            stackList.Add(o);
        }

        public T Top()
        {
            if (!IsEmpty())
                return stackList[stackList.Count - 1];
            else
                throw new InvalidOperationException("Underflow!");
        }

        public T Pop()
        {
            if (!IsEmpty())
            {
                T o = Top();
                stackList.Remove(Top());
                return o;
            }
            else
            {
                throw new InvalidOperationException("Underflow!");
            }
        }

        public int Size()
        {
            return stackList.Count;
        }

    }
}