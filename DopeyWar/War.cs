using System;
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

            _nationList.Add(new Nation("Sweden", 3, 551, 99));
            _nationList.Add(new Nation("USA", 3, 242, 173));
            _nationList.Add(new Nation("Russia", 3, 628, 99));
            _nationList.Add(new Nation("China", 3, 830, 196));
            _nationList.Add(new Nation("North Korea", 3, 866, 166));
            _nationList.Add(new Nation("South Africa", 3, 572, 391));
            _nationList.Add(new Nation("Brazil", 3, 382, 326));
            _nationList.Add(new Nation("Australia", 3, 907, 387));
            _nationList.Add(new Nation("United Kingdom", 3, 503, 122));
            _nationList.Add(new Nation("Iraq", 3, 636, 175));
        }

        public Nation WarStrike(MapForm mf)
        {
            PickNations();        //sets attacker and defender
            mf.DisplayWarActivity(_attacker, _defender);
            _defender.MakeDamage();
            _nationList.Sort();    
            mf.UpDateList(_nationList);

            if (_defender.Endurance == 0)
                mf.DisplayDefeated(_defender);

            if (CheckIfWinner())
                return _attacker;

            return null;
        }

        private void PickNations()
        {
            Random rno = new Random(Guid.NewGuid().GetHashCode());
            _attacker = _nationList[rno.Next(0, 10)];
            _defender = _nationList[rno.Next(0, 10)];
            if (_attacker == _defender)
                PickNations();
            if (_attacker.Endurance == 0 || _defender.Endurance == 0)
                PickNations();
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

        public void AdjustCoordinatesToScale ()
        {
            foreach (Nation n in _nationList)
            {
                n.Coordinates.X = (int)(n.Coordinates.X * Nation._scaleFactorX); //CE
                n.Coordinates.Y = (int)(n.Coordinates.Y * Nation._scaleFactorY); //CE
            }
        }
    }
}
