using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    // 클래스
    //캡슐화하기위한 사용자정의 자료형
    internal struct SwordMan
    {
        // 맴버 변수들
        public string Name;
        public int Lv;
        float _exp;
        char _gender;

        //멤버 함수들
        public void Slash()
        {
            Console.WriteLine($"{Name} 이(가) 베기를 시전했다.");
        }
    }
}


