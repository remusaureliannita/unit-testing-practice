using System;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class StackTests
    {
        private Stack<int?> _stack;

        [SetUp]
        public void SetUp()
        {
            _stack = new Stack<int?>();
        }

        [Test]
        public void Count_EmptyStack_ShludReturnZero()
        {
            Assert.That(_stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Push_WithNull_ShouldThrowArgumentNullException()
        {
            Assert.That(() => _stack.Push(null), Throws.ArgumentNullException);
        }

        [Test]
        public void Push_WithValidArguments_ShouldPlaceItemInStack()
        {
            _stack.Push(1);

            Assert.That(_stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Pop_EpmtyStack_ThrowsInvalidOperationException()
        {
            _stack.Push(1);
            var result = _stack.Pop();

            Assert.That(result, Is.EqualTo(1));
            Assert.That(_stack.Count, Is.EqualTo(0));
            Assert.That(() => _stack.Pop(), Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_ShouldReturnButNotPop()
        {
            _stack.Push(1);
            var result = _stack.Peek();

            Assert.That(result, Is.EqualTo(1));
            Assert.That(_stack.Count, Is.EqualTo(1));
        }

    }
}
