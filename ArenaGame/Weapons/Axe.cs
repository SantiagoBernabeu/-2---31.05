using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Axe : IWeapon
    {
        public string Name { get; set; }
        public double AttackDamage { get; private set; }
        public double BlockingPower { get; private set; }
        public double Skill() => AttackDamage* 0.15;
        public Axe(string name)
        {
            Name = name;
            AttackDamage = 20;
            BlockingPower = 15;
        }
    }
}
