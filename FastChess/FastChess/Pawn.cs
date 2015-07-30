using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
namespace FastChess
{
    class Pawn
    {
        Form1 horse = new Form1();
        Location1 spot = new Location1();
        public void move_p(int x,int y)
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (spot.location_save[i, j, 0] == x && spot.location_save[i, j, 1] == y)
                    {
                        x = spot.location_save[i, j + 1, 0];
                        y = spot.location_save[i, j + 1, 1];
                    }
                }
            }
        }
        
        
    }
}
