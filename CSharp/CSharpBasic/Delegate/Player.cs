using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Player
    {
        public int Hp 
        { 
            get
            {
                return _hp;
            }
            set
            {
                if(_hp == value)
                    return;

                _hp = value;
               /* OnHpChagned(value);
                OnHpChagned.Invoke(value); // Invoke 는 대리자에 둥록된 함수들의 RaceCondition 을 방지하기위해 사용하는 함수 */
                OnHpChagned?.Invoke(value);// ?.Invoke 대리자에 등록된 함수가 없을 경우 호출하지 않는 구문
            }
        }
        private int _hp;
        private int _hpMax = 100;
        public delegate void HPChangedHandler(int hp);
        public HPChangedHandler OnHpChagned;

        public Player()
        {
            Hp = _hpMax;
        }
    }
}
