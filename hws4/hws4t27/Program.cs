// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine ("введите число");
int data = Convert.ToInt32(Console.ReadLine());

Int32 Mdata = Convert.ToInt32(Math.Abs(data));
Console.WriteLine($"Модуль  числа {Mdata}");


int count = 0;
int sum = 0;
int res = 1;
int number = 0;
int numbergap = 0;
while (Mdata-res>=0)
{
    res = 10*res;
    count++;
   
}

Console.WriteLine($"количество цифр в числе {count}"); 

for(int i=1;i<=count; i++){
   
    Int32 gap = Convert.ToInt32(Math.Pow(10, count - i));
    numbergap = Mdata / gap;
    number = numbergap % 10;
    sum = sum + number;
}
Console.WriteLine(sum);