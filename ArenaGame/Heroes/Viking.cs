using ArenaGame.Weapons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Viking : Hero
    {
        public Viking(string name, double armor, double strenght, IWeapon weapon) :
          base(name, armor, strenght, weapon)
        {

        }
        public override double Attack()
        {
            double damage = base.Attack();

            if (Weapon is Katana || Weapon is Dagger)
                damage = base.Attack() - 5;
            return damage;
        }
    }
}
