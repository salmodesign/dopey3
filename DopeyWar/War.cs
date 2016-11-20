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

        public War(int endurance)
        {
            _nationList = new List<Nation>();
            _nationList.Add(new Nation("Sweden", endurance, 551, 99));
            _nationList.Add(new Nation("USA", endurance, 242, 173));
            _nationList.Add(new Nation("Russia", endurance, 628, 99));
            _nationList.Add(new Nation("China", endurance, 830, 196));
            _nationList.Add(new Nation("North Korea", endurance, 866, 166));
            _nationList.Add(new Nation("South Africa", endurance, 572, 391));
            _nationList.Add(new Nation("Brazil", endurance, 382, 326));
            _nationList.Add(new Nation("Australia", endurance, 907, 387));
            _nationList.Add(new Nation("United Kingdom", endurance, 503, 122));
            _nationList.Add(new Nation("Iraq", endurance, 636, 175));

            new Ocean("Pacific Ocean", 890, 220); //For demo purpose (Scaling feature)
            new Ocean("Atlantic Ocean", 430, 300);
        }

        public List<Nation> GetSortedList()
        {
            _nationList.Sort();
            return _nationList;
        }

        public void CreateAttack()
        {
            Random rno = new Random(Guid.NewGuid().GetHashCode());
            _attacker = _nationList[rno.Next(0, 10)];
            _defender = _nationList[rno.Next(0, 10)];

            if (_attacker == _defender || _attacker.Endurance == 0 || _defender.Endurance == 0)
                CreateAttack();
            else
            {
                _attacker.FireShot();
                _defender.MakeDamage();
                if (_defender.Endurance == 0)
                    _attacker.EnemyKilled();
            }
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
