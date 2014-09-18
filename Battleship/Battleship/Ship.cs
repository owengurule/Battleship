using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    class Ship
    {
        //enumeration
        public enum ShipType
        {
            Carrier, Battleship, Cruiser, Submarine, Minesweeper
        }

        //properties
        public ShipType Type { get; set; }
        public List<Point> OccupiedPoints { get; set; }
        public int Length { get; set; }
        public bool IsDestroyed { get { return OccupiedPoints.All(x => x.Status == Point.PointStatus.Hit); } }

        //constructor
        public Ship(ShipType typeOfShip)
        {
            this.OccupiedPoints = new List<Point>();
            this.Type = typeOfShip;
            if (Type == ShipType.Carrier)
            {
                this.Length = 5;
            }
            else if (Type == ShipType.Battleship)
            {
                this.Length = 4;
            }
            else if (Type == ShipType.Cruiser || Type == ShipType.Submarine)
            {
                this.Length = 3;
            }
            else
            {
                this.Length = 2;
            }
        }
    }
}
