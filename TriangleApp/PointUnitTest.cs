using NUnit.Framework;

namespace TriangleApp
{
    [TestFixture]
    public class PointUnitTest
    {
        //Kiểm tra 2 điểm trùng nhau
        [TestCase]
        public void Check1()
        {
            Point X1 = new Point(1, 2);
            Point X2 = new Point(1, 2);

            Assert.AreEqual(X1.Check(X2), false);
        }


        //Kiểm tra 2 điểm trùng nhau hoành độ, khác nhau tung độ
        [TestCase]
        public void Check2()
        {
            Point X1 = new Point(1, 2);
            Point X2 = new Point(1, 3);

            Assert.AreEqual(X1.Check(X2), true);
        }

        //Kiểm tra 2 điểm trùng nhau tung độ, khác nhau hoành độ
        [TestCase]
        public void Check3()
        {
            Point X1 = new Point(1, 2);
            Point X2 = new Point(2, 2);

            Assert.AreEqual(X1.Check(X2), true);
        }

        //Kiểm tra 2 điểm khác nhau hoành độ và tung độ
        [TestCase]
        public void Check4()
        {
            Point X1 = new Point(1, 2);
            Point X2 = new Point(3, 4);

            Assert.AreEqual(X1.Check(X2), true);
        }
    }
}