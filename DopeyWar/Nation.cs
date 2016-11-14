using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopeyWar
{
    public class Nation : IComparable, IScaleable
    {
        private string _name;
        private int _endurance;

        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public int Endurance
        {
            get
            {
                return _endurance;
            }
        }

        public Nation(string name, int endurance, int x, int y)
        {
            _name = name;
            _endurance = endurance;

            PositionX = x;
            PositionY = y;

            Scaling.Add(this);
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
