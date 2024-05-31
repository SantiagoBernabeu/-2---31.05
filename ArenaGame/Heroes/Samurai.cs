using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Samurai : Hero
    {
        public Samurai(string name, double armor, double strenght, IWeapon weapon) :
            base(name, armor, strenght, weapon)
        {

        }
        public override double Attack()
        {
            double damage;

            if (Weapon is Katana) damage = base.Attack() + 3;
            else damage = base.Attack() - 3;
            
            return damage;
        }
    }
}
