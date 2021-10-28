using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace _2_1P11_L7
{
    /// <summary>
    /// Прямоугольник
    /// </summary>
    public class Rectangle: Square
    {
        int b;
        int B { get => b; }
        public Rectangle(int a, int b)
            :base(a)
        {
            Debug.WriteLine("new Rectangle");
            this.b = b;
        }
        public override double S()
        {
            Debug.WriteLine("Rectangle.S");
            return base.S() / A * B;
        }
        public override double P()
        {
            Debug.WriteLine("Rectangle.P");
            return (A + B) * 2;
        }
        public enum Direction { Left=0, Directly=1, Right=2}
        public void Step(Direction direction)
        {
            if (direction == Direction.Left) { }
            if ((int)direction == 2) { }
            x1 = 1;
            x2 = 2;
            //x3 = 3;
        }
    }
}
