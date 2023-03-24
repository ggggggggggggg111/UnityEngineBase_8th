int count = 0;

while (count <10)
{
    Console.WriteLine($"While 반복중... 현재 카운트 : {count}");

    /*if (count == 5)
        continue;*/
    count++;
}

do
{
    Console.WriteLine("안녕");
} while (false);

for(int i = 0; i< 5; i++)
{
    Console.WriteLine($"for 반복중... 현재 카운트 : {i}");
} 

for(int i = 2; i< 25; i+=2)
{
    Console.WriteLine($"for 반복중... 현재 카운트 : {i}");
}  