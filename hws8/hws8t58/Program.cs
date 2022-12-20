// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, заданы 2 массива:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// и

// 1 5 8 5
// 4 9 4 2
// 7 2 2 6
// 2 3 4 7

// Их произведение будет равно следующему массиву:

// 1 20 56 10
// 20 81 8 6
// 56 8 4 24
// 10 6 24 49

void creatematrix(int[,] matrix)
{


    int i = 0;
    int j = 0;

    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
        {

            matrix[i, j] = new Random().Next(0, 10);

        }

    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Операция умножения двух матриц выполнима только в том случае, если число строк в первой матрицу равно числу столбцов во второй; в этом случае говорят, что матрицы согласованы.");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("введите число строк матрицы 1");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов матрицы 1");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число строк матрицы 2");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число столбцов матрицы 2");
int b = Convert.ToInt32(Console.ReadLine());



int[,] neo = new int[n, m];
int[,] trinty = new int[a, b];




creatematrix(neo);
PrintArray (neo);

Console.WriteLine();
creatematrix(trinty);
PrintArray (trinty);
Console.WriteLine();
int[,] smith = new int[n, b];
if (n != b)

{
    Console.WriteLine("матрицы не согласованы");
    return;
}

else
{

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < b; j++)
        {

            smith[i, j] = 0;
            for (int k = 0; k < neo.GetLength(1); k++)
            {
                smith[i, j] += neo[i, k] * trinty[k, j];

            }

        }

    }



}

PrintArray(smith);



