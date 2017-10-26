using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDrawings
{
    public class ClassConsoleDrawing
    {
        public void filling()
        {
            int size = 7;
            char filler = '*';
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {                    
                    Console.Write(filler + " " );
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void fillingBorders()
        {
            int size = 7;
            char filler = '*';
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 ||  j == 0 || j == size - 1)
                    Console.Write(filler + " ");
                    else
                    Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void fillingDiagonal()
        {
            int size = 7;
            char filler = '*';
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j || i + j == size - 1)
                        Console.Write(filler + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void fillingTriangleBottomLeft()
        {
            int size = 7;
            char filler = '*';
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == j || j == 0 || i == size - 1)
                        Console.Write(filler + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void fillingTriangleTopLeft()
        {
            int size = 7;
            char filler = '*';
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i + j == size - 1 || j == 0)
                        Console.Write(filler + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void fillingTriangleTopRight()
        {
            int size = 7;
            char filler = '*';
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == size - 1|| i == j || i == 0)
                        Console.Write(filler + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void fillingTriangleBottomRight()
        {
            int size = 7;
            char filler = '*';
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (j == size - 1 || i + j == size - 1 || i == size - 1)
                        Console.Write(filler + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void fillingHalfTriangleRight()
        {
            int size = 7;
            char filler = '*';
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((j == size - 1 || i + j == size - 1 || i == j) && j > 2)
                        Console.Write(filler + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void fillingHalfTriangleLeft()
        {
            int size = 7;
            char filler = '*';
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((j == 0 || i + j == size - 1 || i == j) && j < 4)
                        Console.Write(filler + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void fillingHalfTriangleTop()
        {
            int size = 7;
            char filler = '*';
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i == 0 || i + j == size - 1 || i == j))
                        Console.Write(filler + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void fillingHalfTriangleBottom()
        {
            int size = 7;
            char filler = '*';
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if ((i == size - 1 || i + j == size - 1 || i == j) && i > 2)
                        Console.Write(filler + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void fillingNumbersFromTop1to7()
        {
            int size = 7;
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(i + 1 + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void fillingNumbersFromTop7to1()
        {
            int size = 7;
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(size - i + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void fillingNumbersFromLeft1to7()
        {
            int size = 7;
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(j + 1 + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

        public void fillingNumbersFromLeft7to1()
        {
            int size = 7;
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(size - j + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
