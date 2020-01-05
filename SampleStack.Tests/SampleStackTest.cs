using NUnit.Framework;
using SampleStack;
using System;

namespace SampleStack.Tests
{
    public class Tests
    {
        IStack<string> vStack;

        [SetUp]
        public void Setup()
        {
            vStack = new SampleStack<string>();
        }

        [Test]
        public void ValidatesIsEmptyTrueInitially()
        {
            Assert.True(vStack.IsEmpty());
        }

        [TestCase("Hello")]
        public void ValidatesPush(string vStr)
        {
            vStack.Push(vStr);
            Assert.False(vStack.IsEmpty());
            Assert.AreEqual(1, vStack.Size());
        }

        [Test]
        public void ValidatesSize()
        {
            IStack<int> intStack = new SampleStack<int>();
            intStack.Push(1);
            intStack.Push(3);
            intStack.Push(2);
            Assert.AreEqual(3, intStack.Size());
        }

        [Test]
        public void ValidatesPopElement()
        {
            IStack<int> intStack = new SampleStack<int>();
            intStack.Push(1);
            intStack.Push(3);
            intStack.Push(2);
            intStack.Pop();
            Assert.AreEqual(2, intStack.Size());
        }

        [Test]
        public void ValidatesizeAfterPop()
        {
            IStack<int> intStack = new SampleStack<int>();
            intStack.Push(1);
            intStack.Pop();
            Assert.True(intStack.IsEmpty());
            Assert.AreEqual(0, intStack.Size());
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void ValidatesPoppedObjEqualsPushedObj(int value) {
            IStack<int> intStack = new SampleStack<int>();
            intStack.Push(value);
            Assert.AreEqual(value, intStack.Pop());
        }

        [Test]
        public void ValidatesRemovedObjectsBackwards() {
            IStack<int> intStack = new SampleStack<int>();
            int[] list = { 1,3,5};
            for(int i=0;i<list.Length;++i)
                intStack.Push(list[i]);
            for(int i=list.Length-1;i>=0;--i) {
                Assert.AreEqual(list[i],intStack.Pop());
            }
        }

        [Test]
        public void ValidatesUnderflowCondition() {
            IStack<int> intStack = new SampleStack<int>();
            var ex = Assert.Throws<InvalidOperationException>(() => intStack.Pop());
            Assert.That(ex.Message, Is.EqualTo("Underflow!"));
        }

        [Test]
        public void ValidatesIsEmptyFollowedByTop() {
            IStack<int> intStack = new SampleStack<int>();
            intStack.Push(1);
            Console.Write(intStack.Top());
            Assert.False(intStack.IsEmpty());
        }

        [Test]
        public void ValidatesTop() {
            vStack.Push("Ishan");
            Assert.AreEqual("Ishan",vStack.Top());
        }

        [Test]
        public void ValidatesTopThrowsErrorForEmptyStack() {
            var ex = Assert.Throws<InvalidOperationException>(()=> new SampleStack<string>().Top());
            Assert.That(ex.Message,Is.EqualTo("Underflow!"));
        }

    }
}