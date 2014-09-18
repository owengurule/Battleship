using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            //make a new grid
            Grid grid = new Grid();
            //call play game for our grid
            grid.PlayGame();
            
        }
    }
}
