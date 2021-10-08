using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Моделирование_процесса_растворения_твердых_тел
{
    class Point
    {
       
        public bool IsSolid { get; private set; }
        //public int X { get; private set; }
        //public int Y { get; private set; }
        int concentration;
        public int Concentration
        {
            get
            {
                return concentration;
            }
        }
        public Point(int concentration)
        {
            //X = x;
            //Y = y;
            //IsSolid = false;
            this.concentration = concentration;
            IsSolid = CalcSolid();
        }

        public bool CalcSolid ()
        {
            return concentration > -500;
        }

    }
}
