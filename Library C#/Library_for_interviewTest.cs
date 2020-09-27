using System;
using AreaLibrary_OOP;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Library_for_interview.Tests
{
    [TestClass]
    public class Library_for_interviewTest
    {
        [TestMethod]
        public void AreaTriangle_exist()
        {
            double a = 3, b = 4, c = 5;

            double actual = Areas.AreaTriangle(a, b, c);
            Assert.AreNotEqual(actual, 0); // Существование треугольника
        }
        [TestMethod]
        public void AreaCircle_RadiusNOTEqual0()
        {
            double r = 5;

            double actual = Areas.AreaCircle(r);
            Assert.AreNotEqual(actual, 0); // Радиус круга не равен 0
        }

        [TestMethod]
        public void AreaCircle_OOP()
        {
            Circle circle = new Circle(5);

            double r = circle.ProcessArea();

            Assert.AreEqual(r, Math.PI * 5);
        }

        [TestMethod]
        public void AreaTriangle_OOP()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            double r = triangle.ProcessArea();

            Assert.AreEqual(r, 6);
        }

        [TestMethod]
        public void AreaUnknownFigure_OOP()
        {
            IProcessArea figure = new Triangle(3, 4, 5);

            double r = figure.ProcessArea();

            Assert.AreEqual(r, 6);
        }

        [TestMethod]
        public void IsRightTriangle_OOP()
        {
            Triangle triangle = new Triangle(3, 4, 5);

            bool isRight = triangle.IsRightTriangle();

            Assert.AreEqual(isRight, true);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))] // Было брошено исключение
        public void BadTriangle_OOP()
        {
            Triangle triangle = new Triangle(4, 4, 14);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))] 
        public void BadCircle_OOP()
        {
            Circle circle = new Circle();
            circle.Radius = -1;
        }
    }
}
