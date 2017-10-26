using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDrawings
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassConsoleDrawing obj = new ClassConsoleDrawing();
            obj.filling();
            obj.fillingBorders();
            obj.fillingDiagonal();
            obj.fillingTriangleBottomLeft();
            obj.fillingTriangleTopLeft();
            obj.fillingTriangleTopRight();
            obj.fillingTriangleBottomRight();
            obj.fillingHalfTriangleRight();
            obj.fillingHalfTriangleLeft();
            obj.fillingHalfTriangleTop();
            obj.fillingHalfTriangleBottom();
            obj.fillingNumbersFromTop1to7();
            obj.fillingNumbersFromTop7to1();
            obj.fillingNumbersFromLeft1to7();
            obj.fillingNumbersFromLeft7to1();
        }
    } 
}
