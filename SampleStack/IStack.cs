using System;

namespace SampleStack
{
    public interface IStack<T>
    {
        bool IsEmpty();
        int Size();
        void Push(T o);
        T Top();
        T Pop();
    }

}
