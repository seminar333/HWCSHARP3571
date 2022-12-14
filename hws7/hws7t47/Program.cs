// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// ​
// m = 3, n = 4.
// ​
// 0,5 7 -2 -0,2
// ​
// 1 -3,3 8 -9,9
// ​
// 8 7,8 -7,1 9


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
