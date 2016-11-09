using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DopeyWar
{
    public class Nation
    {
        private string _name;
        private int _endurance;
        private Point _coordinates;

        public int Endurance
        {
            get
            {
                return _endurance;
            }
        }

        public Point Coordinates
        {
            get
            {
                return _coordinates;
            }
        }


        public Nation(string name, int endurance, int x, int y)
        {
            _name = name;
            _endurance = endurance;
            _coordinates = new Point(x, y);
        }

        public override string ToString()
        {
            return _name;
        }

        public void MakeDamage()
        {
            _endurance--;
        }
    }
}
