// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.WriteLine ("введите размер массива");
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
int sum = 0;

int[] arr = GetRandomArray(size, LEFTRANGE, RIGHTRANGE);

for (int i = 0; i < arr.Length; i++)
{
    if (i % 2 != 0)
    {
        sum = arr[i] + sum;
    }
}
Console.WriteLine();
Console.WriteLine(string.Join(", ", arr));
Console.WriteLine($"сумма элементов стощих на нечетных позициях(1,3,5 итд)- {sum}");