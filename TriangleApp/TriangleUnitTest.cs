using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace TriangleApp
{
    [TestFixture]
    class TriangleUnitTest
    {
        //Kiểm tra tam giác không hợp lệ
        [TestCase]
        public void Check1()
        {
            Point X1 = new Point(0, 1);
            Point X2 = new Point(0, 3);
            Point X3 = new Point(0, 5);

            Triangle t = new Triangle(X1, X2, X3);

            Assert.AreEqual(t.Check(), Tuple.Create(0.0, "Tam giac khong hop le!"));
        }


        //Kiểm tra tam giác thường
        [TestCase]
        public void Check2()
        {
            Point X1 = new Point(1, 2);
            Point X2 = new Point(-3, 1);
            Point X3 = new Point(2, -5);

            Triangle t = new Triangle(X1, X2, X3);

            Assert.AreEqual(t.Check(), Tuple.Create(Math.Round(Math.Sqrt(17) + 5 * Math.Sqrt(2) + Math.Sqrt(61), 2), "Tam giac thuong!"));
        }


        //Kiểm tra tam giác vuông
        [TestCase]
        public void Check3()
        {
            Point X1 = new Point(0, 0);
            Point X2 = new Point(0, 3);
            Point X3 = new Point(4, 0);

            Triangle t = new Triangle(X1, X2, X3);

            Assert.AreEqual(t.Check(), Tuple.Create(12, "Tam giac vuong!"));
        }

        //Kiểm tra tam giác vuông cân
        [TestCase]
        public void Check4()
        {
            Point X1 = new Point(0, 0);
            Point X2 = new Point(0, 2);
            Point X3 = new Point(2, 0);

            Triangle t = new Triangle(X1, X2, X3);

            Assert.AreEqual(t.Check(), Tuple.Create(Math.Round(4 + Math.Sqrt(8), 2), "Tam giac vuong can!"));
        }

        //Kiểm tra tam giác đều
        [TestCase]
        public void Check5()
        {
            Point X1 = new Point(0, Math.Sqrt(12));
            Point X2 = new Point(-2, 0);
            Point X3 = new Point(2, 0);

            Triangle t = new Triangle(X1, X2, X3);

            Assert.AreEqual(t.Check(), Tuple.Create(12, "Tam giac deu!"));
        }

        //Kiểm tra tam giác vuông
        [TestCase]
        public void Check6()
        {
            Point X1 = new Point(0, 0);
            Point X2 = new Point(0, 3);
            Point X3 = new Point(4, 0);

            Triangle t = new Triangle(X1, X2, X3);

            Assert.AreEqual(t.Check(), Tuple.Create(12, "Tam giac vuong!"));
        }
    }

}
