﻿using System;
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
        private int _shots;
        private int _kills;

        public int PosX { get; set; }
        public int PosY { get; set; }
        public string Name { get { return _name; } }

        public int Endurance { get { return _endurance; }}
        public int Shots { get { return _shots; } }
        public int Kills { get { return _kills; } }

        public Nation(string name, int endurance, int x, int y)
        {
            _name = name;
            _endurance = endurance;
            _shots = 0;
            _kills = 0;
            PosX = x;
            PosY = y;

            Scaling.GetInstance().Add(this);        //Adds every new object to scaling control
        }

        public override string ToString()
        {
            return _name;
        }

        public void MakeDamage()
        {
            _endurance--;
        }

        public void FireShot()
        {
            _shots++;
        }

        public void EnemyKilled()
        {
            _kills++;
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
