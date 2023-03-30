﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Character : Creature, IDamageable, IAttackable
    {
        public int Hp
        {
            get
            {
                return hp;
            }

        }

        

        public int AttackPower
        {
            get
            {
                return attackPower;
            }
        }

        protected int hp;
        protected int attackPower;

        public void Damage(int Value)
        {
            if (hp - Value < 0)
                hp = 0;
            else 
                hp -= Value;

        }

        public void Attack(IDamageable target)
        {
            target.Damage(attackPower);
        }
    }
}
