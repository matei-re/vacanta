using Microsoft.VisualStudio.TestTools.UnitTesting;
using Grades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            a.AddGrade(5);

            //asume
            var g = a.ComputeStatistic();
            //assert


             Assert.AreEqual(g.AverageGrade, 5);
        }
    }
}