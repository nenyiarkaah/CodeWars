using NUnit.Framework;

namespace VasyaClerk.Tests
{
    [TestFixture]
    public class LineTests
    {
        [Test]
        public void Test01A()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50 };
            Assert.AreEqual("YES", Line.Tickets(peopleInLine));
        }

        [Test]
        public void Test02A()
        {
            int[] peopleInLine = new int[] { 25, 100 };
            Assert.AreEqual("NO", Line.Tickets(peopleInLine));
        }
        [Test]
        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        public void Test01()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50 };
            Assert.AreEqual("YES", Line.Tickets(peopleInLine));
        }
        [Test]
        public void Test02()
        {
            int[] peopleInLine = new int[] { 25, 100 };
            Assert.AreEqual("NO", Line.Tickets(peopleInLine));
        }
        [Test]
        public void Test03()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 25, 25, 25, 25, 25, 25 };
            Assert.AreEqual("YES", Line.Tickets(peopleInLine));
        }
        [Test]
        public void Test04()
        {
            int[] peopleInLine = new int[] { 50, 50, 50, 50, 50, 50, 50, 50, 50, 50 };
            Assert.AreEqual("NO", Line.Tickets(peopleInLine));
        }
        [Test]
        public void Test05()
        {
            int[] peopleInLine = new int[] { 100, 100, 100, 100, 100, 100, 100, 100, 100, 100 };
            Assert.AreEqual("NO", Line.Tickets(peopleInLine));
        }
        [Test]
        public void Test06()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 50, 100, 50 };
            Assert.AreEqual("YES", Line.Tickets(peopleInLine));
        }
        [Test]
        public void Test07()
        {
            int[] peopleInLine = new int[] { 25, 25 };
            Assert.AreEqual("YES", Line.Tickets(peopleInLine));
        }
        [Test]
        public void Test08()
        {
            int[] peopleInLine = new int[] { 50, 100, 100 };
            Assert.AreEqual("NO", Line.Tickets(peopleInLine));
        }
        [Test]
        public void Test09()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 25, 25, 25, 50, 50, 50, 100, 100, 100, 100 };
            Assert.AreEqual("NO", Line.Tickets(peopleInLine));
        }
        [Test]
        public void Test10()
        {
            int[] peopleInLine = new int[] { 25, 25, 50, 50, 100 };
            Assert.AreEqual("NO", Line.Tickets(peopleInLine));
        }
        [Test]
        public void Test11()
        {
            int[] peopleInLine = new int[] { 25, 25, 25, 25, 25, 100, 100 };
            Assert.AreEqual("NO", Line.Tickets(peopleInLine));
        }
    }
}