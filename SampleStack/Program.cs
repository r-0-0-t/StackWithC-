using System;

namespace SampleStack
{
    public class Program
    {

        public static void Main(string[] args)
        {
            SampleStack<string> stack = new SampleStack<string>();
            stack.Push("hello1");
            stack.Push("hello2");
            stack.Push("hello3");
            stack.Push("hello4");
            Console.Write(stack.Top());
        }
    }
}