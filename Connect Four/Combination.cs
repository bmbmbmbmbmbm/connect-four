using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Connect_Four
{
    class Combination
    {
        private Point Start;
        private int Length;
        private int dX;
        private int dY;
        private int Owner;
        public Combination(Point StartingPoint, int ComboSize, int DifferenceX, int DifferenceY, int Player)
        {
            Start = StartingPoint;
            Length = ComboSize;
            dX = DifferenceX;
            dY = DifferenceY;
            Owner = Player;
        }
        public int[] Gradient()
        {
            return new int[2] { dX, dY };
        }
        public int GetLength
        {
            get { return Length; }
        }
        public Point StartsFrom
        {
            get { return Start; }
        }
        public int GetOwner
        {
            get { return Owner; }
        }
    }
}
