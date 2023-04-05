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
                if (value <= _hpMin)
                    OnHpMin?.Invoke();
                else
                    OnHpChagned?.Invoke(value);// ?.Invoke 대리자에 등록된 함수가 없을 경우 호출하지 않는 구문

            }
        }
        private int _hp;
        private int _hpMax = 100;
        private int _hpMin = 0;
        //public delegate void HPChangedHandler(int hp);
        //public event HPChangedHandler OnHpChagned; // event 한정자 : 대리자를 외부 클래스에서 직접 호출하거나 Invoke 할 수 없도록제한
        public event Action<int> OnHpChagned;
        public event Action OnHpMin;
        private PlayerUI _playerUI1;

        public delegate void SomethingHandler(int a,int b);
        public SomethingHandler OnSomehow;

        // Generic
        public Action<int, int> action; // 반환 타입이 없고, 파라미터는 0개 ~ 16개 까지 정의되어있으므로 쓸 수 있다.  
        public Func<int, float> func; // 반환 타입이 있고, "
        public Predicate<int> predicate;// 반환 타입이 bool, 파라미터는 1개 ~ 16개 까지 "

        public Player()
        {
            Hp = _hpMax;
        }
    }
}
