// Задача 2: Напишите программу,
// которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7, min = 5
// a = 2 b = 10 -> max = 10, min = 2
// a = -9 b = -3 -> max = -3, min = -9

Console.WriteLine("введите число 1");
int data1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число 2");
int data2 = Convert.ToInt32(Console.ReadLine());

if (data1 > data2)
{

    Console.WriteLine("число 1 больше чем число 2");
    Console.WriteLine(data1 > data2);

}
else
{

    Console.WriteLine("число 2 больше чем число 1");
    Console.WriteLine(data2 > data1);

}
