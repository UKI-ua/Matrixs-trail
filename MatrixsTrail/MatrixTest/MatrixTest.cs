using Microsoft.VisualStudio.TestTools.UnitTesting;
using MatrixsTrail;
using System;

namespace MatrixTest
{
    [TestClass]
    public class MatrixTest
    {
        private Matrix _matrix;

        [TestMethod]
        public void TestBorder()
        {
            var lines = 0;
            var columns = 0;

            Assert.ThrowsException<Exception>(() => new Matrix(lines, columns));
        }

        [TestMethod]
        public void TestBorderLeft()
        {
            var lines = -1;
            var columns = -1;

            Assert.ThrowsException<Exception>(() => new Matrix(lines, columns));
        }

        [TestMethod]
        public void TestNullMatrix()
        {
            int[,] matrix = null;

            Assert.ThrowsException<Exception>(() => new Matrix(matrix));
        }

        [TestMethod]
        public void TestEmptyMatrix()
        {
            var matrix = new int[0, 0];

            Assert.ThrowsException<Exception>(() => new Matrix(matrix));
        }

        [TestMethod]
        public void TestMatrix2x2()
        {
            var testMatrix = new int[,] { { 2, 2 }, { 2, 2 } };
            var expexted = 4;
            _matrix = new Matrix(testMatrix);

            Assert.AreEqual(expexted, _matrix.GetMatrixTrail());
        }

        [TestMethod]
        public void TestMatrix2x3()
        {
            var testMatrix = new int[,] { { 2, 2, 6 }, { 2, 2, 1 } };
            var expexted = 4;
            _matrix = new Matrix(testMatrix);

            Assert.AreEqual(expexted, _matrix.GetMatrixTrail());
        }

        [TestMethod]
        public void TestMatrix2x4()
        {
            var testMatrix = new int[,] { { 2, 7, 1, 9 }, { 2, 4, 6, 3 } };
            var expexted = 6;
            _matrix = new Matrix(testMatrix);

            Assert.AreEqual(expexted, _matrix.GetMatrixTrail());
        }

        [TestMethod]
        public void TestMatrix4x1()
        {
            var testMatrix = new int[,] { { 15 }, { 2 }, { 1 }, { 7 } };
            var expexted = 15;
            _matrix = new Matrix(testMatrix);

            Assert.AreEqual(expexted, _matrix.GetMatrixTrail());
        }

        [TestMethod]
        public void TestMatrix4x4()
        {
            var testMatrix = new int[,] { { 15, 12, 11, 3 }, { 2, 4, 1, 6 }, { 1, 0, 9, 4 }, { 7, 7, 8, 0 } };
            var expexted = 28;
            _matrix = new Matrix(testMatrix);

            Assert.AreEqual(expexted, _matrix.GetMatrixTrail());
        }

        [TestMethod]
        public void TestMatrix5x5()
        {
            var testMatrix = new int[,] { { 15, 12, 11, 3, 5 }, { 2, 4, 1, 6, 9 }, { 1, 0, 9, 4, 1 }, { 7, 7, 8, 0, 12 }, { 7, 18, 8, 11, 14 } };
            var expexted = 42;
            _matrix = new Matrix(testMatrix);

            Assert.AreEqual(expexted, _matrix.GetMatrixTrail());
        }

        [TestMethod]
        public void TestMatrix3x3()
        {
            var testMatrix = new int[,] { { 5, 12, 11 }, { 2, 28, 1 }, { 1, 0, 17 } };
            var expexted = 50;
            _matrix = new Matrix(testMatrix);

            Assert.AreEqual(expexted, _matrix.GetMatrixTrail());
        }

        [TestMethod]
        public void TestMatrix4x3()
        {
            var testMatrix = new int[,] { { 53, 12, 11 }, { 2, 4, 1 }, { 1, 0, 9 }, { 7, 7, 8 } };
            var expexted = 66;
            _matrix = new Matrix(testMatrix);

            Assert.AreEqual(expexted, _matrix.GetMatrixTrail());
        }

        [TestMethod]
        public void TestMatrix1x1()
        {
            var testMatrix = new int[,] { { 17 } };
            var expexted = 17;
            _matrix = new Matrix(testMatrix);

            Assert.AreEqual(expexted, _matrix.GetMatrixTrail());
        }

    }
}
