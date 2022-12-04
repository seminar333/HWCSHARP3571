// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
// и выводит их на экран. Данные вводятся с консоли пользователем

int n = 1;
int[] array = new int[8];
for (int i = 0; i < 8; i++)
{


    Console.WriteLine($"Введите число {n}");
    array[i] = Convert.ToInt32(Console.ReadLine());
    n++;
}
Console.WriteLine(string.Join(",", array));
