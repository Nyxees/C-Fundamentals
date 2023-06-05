using _011_HomeWork;
using System.Drawing;

namespace _10_HomeWork_Test
{
    [TestClass]

    //--------------- 1 Task
    public class TestTriangle
    {
        [TestMethod]
        public void CalculateArea()
        {

            Triangle triangle = new Triangle(new Point(0, 0), new Point(0, 3), new Point(4, 0));

            double area = triangle.CalculateArea();

            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void IsEquilateral_True()
        {

            Triangle triangle = new Triangle(new Point(0, 0), new Point(2, 0), new Point(1, (int)Math.Sqrt(3)));

            bool isEquilateral = triangle.IsEquilateral();

            Assert.IsTrue(isEquilateral);
        }

        [TestMethod]
        public void IsEquilateral_False()
        {

            Triangle triangle = new Triangle(new Point(0, 0), new Point(3, 0), new Point(1, (int)Math.Sqrt(3)));

            bool isEquilateral = triangle.IsEquilateral();

            Assert.IsFalse(isEquilateral);
        }
    }

    //----------------- 2 Task (using 11 Homework)
    public class TestStudent
    {
        private bool parentMethodCalled;
        private bool accountancyMethodCalled;

        [TestMethod]
        public void InvokesParentMethod()
        {
 
            Student student = new Student("John");
            Parent parent = new Parent();
            student.MarkChange += parent.OnMarkChange;
            student.MarkChange += accountancy.PayingFellowship;
            parentMethodCalled = false;

            student.AddMark(10);

            Assert.IsTrue(parentMethodCalled);
        }

        [TestMethod]
        public void InvokesAccountancyMethod()
        {

            Student student = new Student("John");
            Accountancy accountancy = new Accountancy();
            student.MarkChange += accountancy.PayingFellowship;
            accountancyMethodCalled = false;

            student.AddMark(10);

            Assert.IsTrue(accountancyMethodCalled);
        }

        [TestMethod]
        public void InvokesBothMethods()
        {

            Student student = new Student("John");
            Parent parent = new Parent();
            Accountancy accountancy = new Accountancy();
            student.MarkChange += parent.OnMarkChange;
            student.MarkChange += accountancy.PayingFellowship;
            parentMethodCalled = false;
            accountancyMethodCalled = false;

            student.AddMark(10);

            Assert.IsTrue(parentMethodCalled);
            Assert.IsTrue(accountancyMethodCalled);
        }
    }
}