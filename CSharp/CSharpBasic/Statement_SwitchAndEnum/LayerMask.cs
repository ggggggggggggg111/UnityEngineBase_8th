using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statement_SwitchAndEnum
{
    //Attribute ?
    //타입의 메타데이터를 정의하는 형태의 클래스
    //메타데이터 ? 데이터의 데이터

    //Flags Attribute
    // 중복된 Flage들을 각 요소들에대한 문자열로 변한해주는 기능을 가지고 있는 Attribut
    [Flags]
    public enum LayerMask
    {
        None   =0 << 0,
        NPC = 1 << 0,
        Enemy  = 1<< 1,
        Player  = 1<<2,
        Ground    = 1<< 2,
        Wall = 1 << 4,
        //EnumyNPC = NPC | Enemy 

    }

    public enum LayerMaskDummy
    {
        None,
        NPC,
        Enemy,
        Player,
        Ground,
        Wall,
        //EnumyNPC = NPC | Enemy 
    }
}
