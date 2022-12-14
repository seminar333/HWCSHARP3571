// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// ​
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


Console.WriteLine("введите колличество строк");
int m = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("введите колличество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

void getMatrix(int[,] Matrix)
{

    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Random rand = new Random();
            Matrix[i, j] = rand.Next(1,10);
            Console.Write(Matrix[i , j ] + " ");
        }
        Console.WriteLine();

    }
}

int[,] matr = new int[m, n];

getMatrix(matr);

Console.WriteLine(matr);



 for (int j = 0; j < matr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        sum += matr[i, j];
    }
    Console.WriteLine($"среднеарифмитическое = { sum / matr.GetLength(0):f2} ");
}
