using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Fist : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }
        public double Skill() => AttackDamage * 5;
        public Fist(string name)
        {
            Name = name;
            AttackDamage = 5;
            BlockingPower = 1;
        }
    }
}
