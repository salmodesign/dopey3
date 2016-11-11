using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DopeyWar
{
    public class Nation : IComparable
    {
        private string _name;
        private int _endurance;
        private Point _coordinates;
        private int _scaleFactorX; //CE
        private int _scaleFactorY; //CE

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
                _coordinates.X *= _scaleFactorX; //CE
                _coordinates.Y *= _scaleFactorY; //CE
                return _coordinates;
            }
        }


        public Nation(string name, int endurance, int x, int y)
        {
            _scaleFactorX = 1;
            _scaleFactorY = 1;
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

        public int CompareTo(object obj)
        {
            Nation otherNation = (Nation)obj;
            int result = _endurance.CompareTo(otherNation._endurance);
            if (result == 0)     //if endurance is equal, sort on country name
                return _name.CompareTo(otherNation._name);
            else
                return -result;  //return the negative
        }
    }
}
