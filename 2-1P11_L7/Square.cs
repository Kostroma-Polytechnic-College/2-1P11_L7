using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1P11_L7
{
    public class Square : Figure
    {
        int a;

        public int A
        {
            get
            {
                return a;
            }
        }
        public Square(int a)
        {
            Debug.WriteLine("new Square");
            this.a = a;
        }
        public override double P()
        {
            Debug.WriteLine("Square.P");
            return A * 4;
        }

        public override double S()
        {
            Debug.WriteLine("Square.S");
            return A * A;
        }
    }
}
