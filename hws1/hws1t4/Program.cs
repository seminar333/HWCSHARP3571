// Задача 4: Напишите программу, которая принимает на вход
// три числа и выдает максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("введите число 1");
int data1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число 2");
int data2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число 3");
int data3 = Convert.ToInt32(Console.ReadLine());

int max = data1;

if (data1 > max) max = data1;
if (data2 > max) max = data2;
if (data3 > max) max = data3;

Console.Write("максимальное число равняется  ");
Console.WriteLine(max);

