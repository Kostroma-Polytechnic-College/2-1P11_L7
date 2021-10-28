using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_1P11_L7
{
    interface IFigure
    {
        double P();
    }

    /// <summary>
    /// Фигура
    /// </summary>
    abstract public class Figure: IFigure
    {
        abstract public double S();

        abstract public double P();

        public int x1;
        protected int x2;
        private int x3;
        public void Rotation()
        {
            x1 = 1;
            x2 = 2;
            x3 = 3;
        }
    }
}
