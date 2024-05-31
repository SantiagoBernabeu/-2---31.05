using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Katana : IWeapon
    {
        private int hitCount;
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }
        public double Skill()
        {
            hitCount++;
            if (hitCount == 1) return AttackDamage * 0.25;

            if (hitCount == 2)  hitCount = 0; 

            return AttackDamage*0.5;
        }
        public Katana(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 10;
        }
    }
}
