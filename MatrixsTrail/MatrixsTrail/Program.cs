using System;

namespace MatrixsTrail
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfColumns;
            int numberOfLines;

            do
            {
                Console.Write("Enter number of lines: ");
                numberOfLines = int.Parse(Console.ReadLine());

                Console.Write("Enter number of columns: ");
                numberOfColumns = int.Parse(Console.ReadLine());

                if (numberOfLines < 1 || numberOfColumns < 1)
                    Console.WriteLine("Wrong input! Try again");
            }
            while (numberOfLines < 1 || numberOfColumns < 1);

            try
            {
                var matrix = new Matrix(numberOfLines, numberOfColumns);

                Console.WriteLine("Your matrix is:");
                matrix.PrintOnConsole();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();

        }
    }
}
