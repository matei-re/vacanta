using Grades;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nume.Tests
{
    [TestClass()]
    public class GradeBookTests
    {
        [TestMethod]
        public void MyTestMethod()
        {
            var b1 = new GradeBook();
            var b2 = new GradeBook();
            GetName(b2);
            Assert.AreNotEqual(b2.name, b1.name);

        }
        private void GetName(GradeBook book)
        {
            book.name = "Mara";
        }
        [TestMethod()]
        public void GradeBookTest()
        {
           var g1 = new GradeBook();
            g1.name = "Raluca's list";
            var g2 = new GradeBook();
            Assert.AreNotEqual(g2.name, g1.name);
        }

        
    }
}

namespace Grades.Tests
{
    [TestClass()]
    public class GradeBookTests
    {
        [TestMethod()]
        public void ComputeStatisticTest()
        {
            //arrange
            var a = new GradeBook();
            a.AddGrade(5);
            a.AddGrade(7);

            //asume
            var g = a.ComputeStatistic();
            //assert


             Assert.AreEqual(g.AverageGrade, 6);
        }
        [TestMethod()]
        public void ComputeStatisticHigh()
        {
            //arrange
            var a = new GradeBook();
            a.AddGrade(7);
            a.AddGrade(5);

            //asume
            var g = a.ComputeStatistic();
            //assert


            Assert.AreEqual(g.HighGrade, 7);
        }
    }
}