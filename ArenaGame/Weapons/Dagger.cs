using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Dagger : IWeapon
    {
        private int hitCount;
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }
        public double Skill()
        {
            hitCount++;
            if (hitCount == 1) return AttackDamage * 0.1;
            if (hitCount == 2) return AttackDamage * 0.2;
            if (hitCount == 3) hitCount = 0;
                
                return AttackDamage * 0.5;
        }
        public Dagger(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 1;
        }
    }
}
