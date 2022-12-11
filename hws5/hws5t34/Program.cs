// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GetRandomArray(int size, int leftRange = 100, int rightRange = 998)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}

// int counter (int n){
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] % 2 == 0)
//     {
//         n++;
//     }
//     
// }
// return n;
// }

const int SIZE = 6;
const int LEFTRANGE = 100;
const int RIGHTRANGE = 998;
int count = 0;
int[] arr = GetRandomArray(SIZE, LEFTRANGE, RIGHTRANGE);

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    {
        count++;
    }
}
// int count = counter(n);
Console.WriteLine();
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine($"количество четных чисел- {count}");