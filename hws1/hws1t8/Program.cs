// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8




Console.WriteLine("введите число N");
int N = Convert.ToInt32(Console.ReadLine());


// условие N > 0 добавил в качестве тренировки
if (N > 0)
{

    if (N % 2 == 0)
    {

        for (int i = 1; i <= N; i++)
        {

            i = i + 1;
            Console.WriteLine(i);
        }

    }

    else
    {
        for (int i = 1; i < N; i++)
        {

            i = i + 1;
            Console.WriteLine(i);
        }

    }
}

else
{

    if (N % 2 == 0)

    {

        for (int i = -1; N <= i; i = i - 1)
        {

            i = i - 1;
            Console.WriteLine(i);
        }
    }
    else

    {

        for (int i = -1; N < i; i = i - 1)

        {

            i = i - 1;
            Console.WriteLine(i);
        }


    }

}


// Можно впринципе и так, как лучше не знаю :(((
// if (N % 2 == 0 && N > 0)
// {

// int i = 1;

// while (i<=N)

// i = i+1;
// Console.WriteLine (i);

// }

// и так  далее перебрать все варианты
