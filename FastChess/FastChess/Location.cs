using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastChess
{
    class Location1
    {

        private int[, ,] location = new int[8, 9, 2];
        public int[, ,] location_save
        {
            get { return location; }
            set { location = value; }
        }
    }
}