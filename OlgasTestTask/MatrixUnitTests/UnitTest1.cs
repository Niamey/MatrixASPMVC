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
        public void TestCheckGenerateMatrix1()
        {
            int m = 3;
            int[,] array = new int[m, m];
            Core.Core.GenerateMatrix(array);

            Assert.AreNotEqual(0, array[2, 2]);
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
            var check = Core.Core.TraverseMatrix(array);

            Assert.IsNotNull(check);
        }

    }
}
