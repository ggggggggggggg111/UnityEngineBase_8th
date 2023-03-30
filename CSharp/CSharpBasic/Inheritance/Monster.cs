using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal  abstract class Monster : Creature,IDamageable
    {
        public int Hp
        {
            get
            {
                return hp;
            }

        }
        protected int hp;

        public void Damage(int Value)
        {
            if (hp - Value < 0)
                hp = 0;
            else
                hp -= Value;

        }
    }
}
