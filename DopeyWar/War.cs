﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DopeyWar
{
    public class War
    {
        private Nation _attacker;
        private Nation _defender;
        private List<Nation> _nationList;

        public War()
        {
            _nationList = new List<Nation>();

            _nationList.Add(new Nation("Sweden", 3, 0, 0));
            _nationList.Add(new Nation("USA", 3, 0, 0));
            _nationList.Add(new Nation("Russia", 3, 0, 0));
            _nationList.Add(new Nation("China", 3, 0, 0));
            _nationList.Add(new Nation("North Korea", 3, 0, 0));
            _nationList.Add(new Nation("South Africa", 3, 0, 0));
            _nationList.Add(new Nation("Brazil", 3, 0, 0));
            _nationList.Add(new Nation("Australia", 3, 0, 0));
            _nationList.Add(new Nation("United Kingdom", 3, 0, 0));
            _nationList.Add(new Nation("Iraq", 3, 0, 0));
        }

        public Nation WarStrike(MapForm mf)
        {
            Randomize();        //sets attacker and defender
            mf.DrawMissile(_attacker, _defender);
            _defender.MakeDamage();
            _nationList.Sort();    
            mf.UpDateList(_nationList);

            if (_defender.Endurance == 0)
                mf.DisplayDefeated(_defender);

            if (CheckIfWinner())
                return _attacker;

            return null;
        }

        private void Randomize()
        {
            Random rno = new Random(Guid.NewGuid().GetHashCode());
            _attacker = _nationList[rno.Next(0, 10)];
            _defender = _nationList[rno.Next(0, 10)];
            if (_attacker == _defender)
                Randomize();
            if (_attacker.Endurance == 0 || _defender.Endurance == 0)
                Randomize();
        }

        private bool CheckIfWinner()
        {
            int counter = 0;
            foreach (var n in _nationList)
            {
                if (n.Endurance > 0)
                    counter++;
            }
                
            if (counter == 1)   //ONE single winner!
                return true;
            return false;
        }
    }
}
