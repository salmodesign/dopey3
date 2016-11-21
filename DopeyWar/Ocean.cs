using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopeyWar
{
    public class Ocean : IScaleable //Ocean class for demo purpose
    {
        private string _name;

        public int PosX { get; set; }
        public int PosY { get; set; }
        public string Name { get { return _name; } }

        public Ocean(string name, int x, int y)
        {
            _name = name;
            PosX = x;
            PosY = y;

            Scaling.GetInstance().Add(this);        //Adds every new object to scaling control
        }
    }
}
