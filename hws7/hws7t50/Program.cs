// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// ​
// 5 9 2 3
// ​
// 8 4 2 4
// ​
// 1 7 -> такого числа в массиве нет



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



int Task50(int[,] matr)
{
    int result = 0;
    // int a = 3;
    // int b = 3;
    Console.WriteLine("введите i");
int a = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("введите j");
int b = Convert.ToInt32(Console.ReadLine());
    if(a< matr.GetLength(0) && b< matr.GetLength(1)){
    
   
        result = matr[a,b];
    }
    else {Console.WriteLine ("число не входит в матрицу");}
    return result;
    
}



int[,] matr = new int[m, n];

getMatrix(matr);
int res = Task50 (matr);
Console.WriteLine(matr);
Console.WriteLine(res);