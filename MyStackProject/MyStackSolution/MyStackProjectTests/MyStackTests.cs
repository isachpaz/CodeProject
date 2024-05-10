using MyStackLib;
using NUnit.Framework;

namespace MyStackProjectTests
{
    [TestFixture]
    public class MyStackTests
    {
        [Test]
        public void AddOneIntegerInStack_Test()
        {
            var mystack = new MyStack();
            mystack.Push(5);
        }

        [Test]
        public void IsMyStackEmpty_Test()
        {
            var mystack = new MyStack();
            var isEmpty = mystack.IsEmpty();
            Assert.AreEqual(isEmpty, true);
        }

        [Test]
        public void PushOneNumber_IsMyStackEmpty_Test()
        {
            var mystack = new MyStack();
            mystack.Push(5);
            var isEmpty = mystack.IsEmpty();
            Assert.AreEqual(isEmpty, false);
        }

        [Test]
        public void PushTwoNumbers_PullOne_Test()
        {
            var myStack = new MyStack();
            myStack.Push(5);
            myStack.Push(50);
            int number = myStack.Pull();
            Assert.AreEqual(number, 50);
        }

        [Test]
        public void PushOne_PullTwice_Test()
        {
            var myStack = new MyStack();
            myStack.Push(5);
            myStack.Pull();
            var number = myStack.Pull();


            Assert.AreEqual(number, int.MinValue);
        }
    }
}