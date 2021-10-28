using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1P11_L7
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure item1 = new Square(2);
            Rectangle item2 = new Rectangle(2, 3);

            item1.P();
            item1.S();

            item2.P();
            item2.S();

            item2.Step(Rectangle.Direction.Left);

            ////Figure item2 = new Figure();
            //Rectangle item3 = new Rectangle();

            //item1.Rotation();
            ////item2.Rotation();
            //item3.Rotation();

            //(item1 as Rectangle).Step();
            ////item2.Step();            
            //item3.Step();

            //item1.x1 = 1;
            ////item1.x2 = 2;
            ////item1.x3 = 3;

            ////item2.x1 = 1;
            ////item2.x2 = 2;
            ////item2.x3 = 3;

            //item3.x1 = 1;
            ////item3.x2 = 2;
            ////item3.x3 = 3;


        }
    }
}
