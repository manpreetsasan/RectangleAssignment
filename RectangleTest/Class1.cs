using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rectangle;
using NUnit.Framework;

namespace Rectangle
{
    [TestFixture]
    public class RectangleTest
    {

        [Test]
        public void GetLength_Input45_Returns45()
        {

            //Arrange
            int length = 45;
            int width = 14;

            int expectedResult = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetLength();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }


        [Test]
        public void GetWidth_Input56_Returns56()
        {

            //Arrange
            int length = 70;
            int width = 56;

            int expectedResult = width;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetWidth();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetLength_Input11_Returns11()
        {

            //Arrange
            int length = 11;
            int width = 30;

            int expectedResult = length;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.SetLength(length);

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void Setwidth_Input24_Returns24()
        {

            //Arrange
            int length = 34;
            int width = 24;

            int expectedResult = width;

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.SetWidth(width);

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input_Length12And_Width10_Returns44()
        {

            //Arrange
            int length = 12;
            int width = 10;

            int expectedResult = 2 * (length + width);

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetPerimeter();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input_Length25And_Width20_Returns500()
        {

            //Arrange
            int length = 25;
            int width = 20;

            int expectedResult = (length * width);

            Rectangle testRectangle = new Rectangle(length, width);

            //Act 
            double actualResult = testRectangle.GetArea();

            //Assert 
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
