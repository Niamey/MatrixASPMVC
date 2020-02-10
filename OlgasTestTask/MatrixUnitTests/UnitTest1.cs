using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MatrixUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckGenerateMatrix()
        {
            int m = 3;
            int[,] array = new int[m, m];
             Core.Core.GenerateMatrix(array);
           
            Assert.AreNotEqual(0,array[1,1]);
        }

        [TestMethod]
        public void TestCheckGenerateMatrix2()
        {
            int[,] array = new int[2,2];
            Core.Core.GenerateMatrix(array);

            Assert.AreNotEqual(0, array[2, 2]);
        }

        [TestMethod]
        public void TestCheckGenerateMatrix1()
        {
            int m = 3;
            int[,] array = new int[m, m];
            Core.Core.GenerateMatrix(array);

            Assert.AreNotEqual(0, array[2, 2]);
        }

        [TestMethod]
        public void TestCheckGenerateMatrixDifferentDementions()
        {
           
            int[,] array = new int[1,1];
            Core.Core.GenerateMatrix(array);

            Assert.AreNotEqual(0, array[2, 2]);
        }

        [TestMethod]
        public void TestCheckGenerateDifferentDementionsMatrix()
        {

            int[,] array = new int[2,0];
            Core.Core.GenerateMatrix(array);

            Assert.IsNotNull(array);
            Assert.AreNotEqual(0,array[0,0]);
            Assert.AreNotEqual(0, array[1, 0]);

        }


        [TestMethod]
        public void TestCheckGenerateMatrixNotNull()
        {
            int m = 3;
            int[,] array = new int[m, m];
            var check= Core.Core.GenerateMatrix(array);

            Assert.IsNotNull(check);
        }


        [TestMethod]
        public void TestCheckTraverseMatrixNotNull()
        {
            int m = 3;
            int[,] array = new int[m, m];
            var check = Core.Core.RotateMatrixClockwise(array);

            Assert.IsNotNull(check);
        }

        [TestMethod]
        public void TestCheckCorrectMatrix()
        {
            int[,] a = new int[4, 3];
            a[0, 0] = 0;
            a[0, 1] = 1;
            a[0, 2] = 2;
            a[1, 0] = 3;
            a[1, 1] = 4;
            a[1, 2] = 5;
            a[2, 0] = 6;
            a[2, 1] = 7;
            a[2, 2] = 8;
            a[3, 0] = 9;
            a[3, 1] = 10;
            a[3, 2] = 11;
            var an = Core.Core.RotateMatrixClockwise(a);


            Assert.IsTrue(an[0,0]==a[3,0]);
            Assert.IsTrue(an[0, 1] == a[2, 0]);
            Assert.IsTrue(an[0, 2] == a[1, 0]);
            Assert.IsTrue(an[0, 3] == a[0, 0]);
            Assert.IsTrue(an[1, 0] == a[3, 1]);
            Assert.IsTrue(an[1, 1] == a[2, 1]);
            Assert.IsTrue(an[1, 2] == a[1, 1]);
            Assert.IsTrue(an[1, 3] == a[0, 1]);
            Assert.IsTrue(an[2, 0] == a[3, 2]);
            Assert.IsTrue(an[2, 1] == a[2, 2]);
            Assert.IsTrue(an[2, 2] == a[1, 2]);
            Assert.IsTrue(an[2, 3] == a[0, 2]);
        }

    }
}
