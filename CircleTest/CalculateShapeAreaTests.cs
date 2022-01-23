using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculateShapeArea;
using System.Collections.Generic;


namespace CalculateShapeArea.Tests
{/// <summary>
/// Тестирование рассчета площади фигур.
/// </summary>
/// Круг.
    [TestClass]
    public class CircleTests
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void InfinityRadius()
        {
            var circle = new Circle(double.PositiveInfinity);
            var area = circle.Area;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ZeroLengthRadius()
        {
            var circle = new Circle(0.0);
            var area = circle.Area;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeRadius()
        {
            var circle = new Circle(-10.0);
            var area = circle.Area;
        }

        [TestMethod]
        public void MaxDoubleArea()
        {
            var circle = new Circle(double.MaxValue / 2);
            var area = circle.Area;
            Assert.AreEqual(area, double.PositiveInfinity);
        }

       
    }
    /// <summary>
    /// Треугольник.
    /// </summary>
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod]
        public void RightTriangle()
        {
            var triangle = new Triangle(3.0, 4.0, 5.0);
            var right = triangle.IsRightTriangle();
            Assert.AreEqual(right, true);
        }

        [TestMethod]
        public void IsNotRightTriangle()
        {
            var triangle = new Triangle(3.0, 4.0, 6.0);
            var right = triangle.IsRightTriangle();
            Assert.AreEqual(right, false);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeLengthSidesAll()
        {
            var triangle = new Triangle(-14.0, -9.0, -6.0);
            var area = triangle.Area;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeLengthSides_1()
        {
            var triangle = new Triangle(-14.0, 9.0, 6.0);
            var area = triangle.Area;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NegativeLengthSides_2()
        {
            var triangle = new Triangle(-14.0, 9.0, -6.0);
            var area = triangle.Area;
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ZeroLengthSidesAll()
        {
            var triangle = new Triangle(0.0, 0.0, 0.0);
            var area = triangle.Area;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ZeroLengthSides_1()
        {
            var triangle = new Triangle(0.0, 1.0, 2.0);
            var area = triangle.Area;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ZeroLengthSides_2()
        {
            var triangle = new Triangle(0.0, 1.0, 0.0);
            var area = triangle.Area;
        }
                
        [TestMethod]
        public void MaxDoubleArea()
        {
            var triangle = new Triangle(double.MaxValue / 3, double.MaxValue / 3, double.MaxValue / 3);
            var area = triangle.Area;
            Assert.AreEqual(area, double.PositiveInfinity);
        }
                      
    }




}






