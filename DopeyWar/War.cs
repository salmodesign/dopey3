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

        public Nation Attacker { get { return _attacker; } }
        public Nation Defender { get { return _defender; } }

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

        public List<Nation> GetSortedList()
        {
            _nationList.Sort();
            return _nationList;
        }

        public void PickNations()
        {
            Random rno = new Random(Guid.NewGuid().GetHashCode());
            _attacker = _nationList[rno.Next(0, 10)];
            _defender = _nationList[rno.Next(0, 10)];

            if (_attacker == _defender || _attacker.Endurance == 0 || _defender.Endurance == 0)
                PickNations();
            else
                _attacker.FireShot();   
        }

        public bool CheckIfWinner()
        {
            int counter = 0;
            foreach (var n in _nationList)
            {
                if (n.Endurance > 0)
                    counter++;
            }
                
            if (counter == 1)           //ONE single winner!
                return true;
            return false;
        }
    }
}
