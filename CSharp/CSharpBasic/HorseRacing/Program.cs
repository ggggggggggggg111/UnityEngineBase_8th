using HorseRacing;
using System;
using System.Threading;

Random _random;
float _minSpeed = 10.0f;
float _maxSpeed = 20.0f;
double _posGoal = 200.0f;
bool _isGameFinished = false;
int _currentGrade = 0;
int _sec = 0;
Horse[] _horsesArrived = new Horse[5];

Horse[] horses = new Horse[5];

for (int i = 0; i < horses.Length; i++)
{
    horses[i] = new Horse();
    horses[i].Name = $"경주마{i + 1}";
    

}
//말달리는 루프
while (_isGameFinished == false)
{
    Console.WriteLine($"========================{_sec}초 경과=====================");
    for (int i = 0; i <horses.Length; i++)
    {
        if (horses[i].IsFinished)
        {

            Console.WriteLine($"{horses[i].Name}는 도착함");
        }
        else
        {
            _random = new Random();
            double deltaMovePerSec = (_random.NextDouble() + 1.0) * 10.0;
            horses[i].Move(deltaMovePerSec);

            if (horses[i].TotalDistance >= _posGoal)
            {
                horses[i].IsFinished =true;
                _horsesArrived[_currentGrade] = horses[i];
                _currentGrade++;
            }
            Console.WriteLine($"{horses[i].Name}의 현재거리는 {horses[i].TotalDistance}");
        }

    }
    

    if (_currentGrade >= 5)
    {
        break;
    }
    Thread.Sleep(1000);
    _sec++;
}
Console.WriteLine("경기종료");

for (int i = 0; i < _horsesArrived.Length; i++)
{
    Console.WriteLine($"{i + 1}등 : {_horsesArrived[i].Name}");
}