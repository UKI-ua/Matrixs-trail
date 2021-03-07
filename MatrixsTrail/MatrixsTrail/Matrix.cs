using System;
using System.Collections.Generic;
using System.Text;

namespace MatrixsTrail
{
    public class Matrix
    {
        private readonly int[,] _matrix;

        public Matrix(int l, int c)
        {
            ValidationData(l, c);

            _matrix = new int[l, c];

            FillMatrix();
        }

        public Matrix(int[,] matrix)
        {
            _matrix = matrix ?? throw new Exception("Null reference");

            ValidationData(matrix.GetLength(0), matrix.GetLength(1));
        }

        public int GetMatrixTrail()
        {
            var lines = _matrix.GetLength(0);
            var columns = _matrix.GetLength(1);
            var trail = 0;

            for (int i = 0; i < lines; i++)
            {

                for (int k = 0; k < columns; k++)
                {
                    if (i == k)
                    {
                        trail += _matrix[i, k];
                    }
                }
            }

            return trail;
        }

        public void PrintOnConsole()
        {
            var lines = _matrix.GetLength(0);
            var columns = _matrix.GetLength(1);

            for (int i = 0; i < lines; i++)
            {

                for (int k = 0; k < columns; k++)
                {
                    if (i == k)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("{0,3:G}", _matrix[i, k]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("{0,3:G}", _matrix[i, k]);
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine("Matrix's trail is: {0:G}", GetMatrixTrail());
        }

        private void FillMatrix()
        {
            var lines = _matrix.GetLength(0);
            var columns = _matrix.GetLength(1);
            var random = new Random();

            for (int i = 0; i < lines; i++)
            {

                for (int k = 0; k < columns; k++)
                {

                    _matrix[i, k] = random.Next(101);
                }
            }
        }

        private void ValidationData(int l, int c)
        {
            if (l < 1 || c < 1)
                throw new Exception("Cannot contains zero lines or columns!");
        }

    }
}
