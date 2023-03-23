
using Statement_SwitchAndEnum;
using System.Diagnostics;
/*switch ()
{
	case 값1:
		{
			매개변수의 값
		}
	break;
        case 값2:

    case
	case
	default:
		break;
}*/



int state =3;

switch (state)
{
	case 0:
		Console.WriteLine("상태가 0이다");
		break;
	case 1:
        Console.WriteLine("상태가 1이다");
        break;
	case 2:
        Console.WriteLine("상태가 2이다");
        break;
	default:
        Console.WriteLine("알 수 없는 상태이다");
        break;
}

PlayerState playerState = PlayerState.Idle;

//명시적 캐스팅 :
// R-Value 를 L-Value 에 대입하기위해서 형 변환을 해야하고, 그것을 명시하는것
int tmp = (int)playerState;
playerState= (PlayerState)0;

// 암시적 캐스팅
// R-Value 를 L-Value 에 대입하기위해서 별도로 형 변환을 하지 않아도 연산이 가능한 경우
//보통 자료형의 승격이 일어나는 경우 암시적 캐스팅이 가능하다.
// 승격 : 동일한 포멧의 자료형인데 더 사이즈가 큰 자료형을 연산하는 레지스터롤 연산할 때
float f1 = 0.71f;
double d1 = 1.2f;
d1 = f1;
f1 = (float)d1;

switch (playerState)
{
	case PlayerState.Idle:
        Console.WriteLine("플레이어의 상태는 Idle");
        break;
	case PlayerState.Move:
        Console.WriteLine("플레이어의 상태는 Move");
        break;
	case PlayerState.Jump:
        Console.WriteLine("플레이어의 상태는 Jump");
        break;
	case PlayerState.Attack:
        Console.WriteLine("플레이어의 상태는 Attack");
        break;      
	case PlayerState.Skill:
        Console.WriteLine("플레이어의 상태는 Skill");
        break;
	default:
		break;
}


Player player= new Player();
player.Layer = 2;
if ((LayerMask)player.Layer == LayerMask.Player||
	(LayerMask)player.Layer == LayerMask.Enemy||
	(LayerMask)player.Layer == LayerMask.NPC)
{
	Console.WriteLine("생명체 감지");
}

LayerMask targetMask = LayerMask.Enemy | LayerMask.NPC;

Console.WriteLine(targetMask);

if ((1 << player.Layer & (int)targetMask) > 0)
{
	Console.WriteLine("타겟 감지됨");
}
