
// 배열
// 메모리공간이 연속적인 데이터 포멧이 자료형
//배열의 선언
// 자료형[] 이름 = new 자료형[갯수]
// 자료형[] 이름 = { 값1,값2,값3,...}

int[] intArr = new int[5];

intArr[0] =1;
// [] 인덱서
// 배열의 인덱서 :
// (배열의 첫번째주소 + 인덱스 * 자료형) 의 주소부터 자료형크기만큼의 데이터에 접근

Dummy[] dummies= new Dummy[3];
dummies[0] = new Dummy();
dummies[1] = new Dummy();
dummies[2] = new Dummy();

int[][] intArrArr = new int[3][];

string name = "gite";
Console.WriteLine(name[0]);
Console.WriteLine(name[1]);
Console.WriteLine(name[2]);
Console.WriteLine(name[3]);

for (int i = 0; i < name.Length; i++)
{
    Console.WriteLine(name[i]);
}
class Dummy
{
    int a;
}