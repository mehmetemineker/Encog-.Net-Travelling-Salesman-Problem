using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.GSP
{
    public class City
    {
        private int x;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        private int y;

        public int Y
        {
            get { return y; }
            set { y = value; }
        }


        public City(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Proximity(City city)
        {
            int xdiff = x - city.x;
            int ydiff = y - city.y;

            return (int)Math.Sqrt(xdiff * xdiff + ydiff * ydiff);
        }
    }
}
