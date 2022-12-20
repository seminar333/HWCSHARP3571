// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 1 2 4 7
// 2 3 5 9
// 2 4 4 8

Console.WriteLine("введите колличество строк");
int m = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("введите колличество столбцов");
int n = Convert.ToInt32(Console.ReadLine());

void getMatrix(double[,] Matrix)
{

    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            Random rand = new Random();
            Matrix[i, j] = rand.NextDouble() * (10 + 10) - 10;
            Console.Write(Matrix[i , j ] + " ");
        }
        Console.WriteLine();

    }
}

double[,] matr = new double[m, n];




getMatrix(matr);
Console.WriteLine(matr);
Console.WriteLine();
Console.WriteLine();

void sort(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int q = 0; q < array.GetLength(1) - 1; q++)
            {
                if (array[i, q] > array[i, q + 1])
                {
                    double temp = array[i, q + 1];
                    array[i, q + 1] = array[i, q];
                    array[i, q] = temp;
                     
                }
                // Console.Write($"{array[i , j ]:f2}  " + " ");// почему так не получается?(((
            }
        }
    }
}
 

sort (matr);



    PrintArray (matr);

    
void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]:f2}   ");
        }
        Console.WriteLine();
    }
}