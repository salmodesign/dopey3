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
        public Point Coordinates;

        public static double _scaleFactorX; //CE
        public static double _scaleFactorY; //CE

        public int Endurance
        {
            get
            {
                return _endurance;
            }
        }

        //public Point Coordinates
        //{
        //    get
        //    {   
        //        return _coordinates;
        //    }
        //    set
        //    {
        //        _coordinates = value;
        //    }
        //}


        public Nation(string name, int endurance, int x, int y)
        {
            _scaleFactorX = 1;
            _scaleFactorY = 1;
            _name = name;
            _endurance = endurance;
            Coordinates = new Point(x, y);
        }

        public override string ToString()
        {
            return _name;
        }

        public void MakeDamage()
        {
            _endurance--;
        }

        public static void SetNewScaleFactors(int xOrg, int xNew, int yOrg, int yNew)
        {
            _scaleFactorX = xNew / (double) xOrg;
            _scaleFactorY = yNew / (double) yOrg;           
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
