// Задача 38: Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] GetRandomArray(int size, int leftRange = -1000, int rightRange = 1000)
{
    int[] array = new int[size];
    Random rand = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(leftRange, rightRange + 1);
    }

    return array;
}


const int LEFTRANGE = -1000;
const int RIGHTRANGE = 1000;
int rez = 0;
int max = 0;
int min = 0;

int[] arr = GetRandomArray(size, LEFTRANGE, RIGHTRANGE);

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max) max = arr[i];
    if (arr[i] <min) min=arr[i];
    rez = max - min;
}
Console.WriteLine();
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine($"max =  {max}");
Console.WriteLine($"min =  {min}");
Console.WriteLine($"разница между min и max =  {rez}");