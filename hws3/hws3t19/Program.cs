// Задача 19

// Напишите программу, которая принимает на вход пятизначное число
//  и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("введите число");
int data = Convert.ToInt32(Console.ReadLine());

Int32 Mdata = Convert.ToInt32(Math.Abs(data));
Console.Write("Модуль  числа ");
Console.WriteLine(Mdata);

Int32 count = 0;

Int64 res = 1;


while (Mdata - res >= 0)
{

    res = res * 10;

    count = count + 1;

}

Console.WriteLine($"колличество цифр в  числе  {count}");
if (count <= 1)
{

    Console.WriteLine("число не является палиндромом");
}
else
{

    int i = 1;

    int[] array = new int[count];
    int index = 0;
    int leftnumber = 0;
    int rightnumber = 0;
    int k = 1;
    int leftres = 1;
    int rightres = 1;
    int n = 1;
    int templ = 1;// можно и без них
    int tempr = 1;//можно и без них
    // int templ1 = 1;
    // int tempr1 = 1;
    while (i <= count / 2)
    {

        Int32 gapl = Convert.ToInt32(Math.Pow(10, count - i));
        leftnumber = data / gapl;



        if (i >= 2)
        {



            leftres = leftnumber % 10;
            array[index] = leftres;

        }
        else
        {
            leftres = leftnumber;
            templ = leftres;
            array[0] = templ;




        }

        Console.WriteLine($"цифра {n} слева, {leftres}");

        Int32 gapr = Convert.ToInt32(Math.Pow(10, i));
        rightnumber = data % gapr;

        if (i >= 2)
        {

            Int32 r = Convert.ToInt32(Math.Pow(10, k));
            rightres = rightnumber / r;
            array[count - 1 - index] = rightres;
            k++;



        }
        else
        {

            rightres = rightnumber;
            tempr = rightres;
            array[count - 1] = tempr;

        }

        
    
        Console.WriteLine($"цифра {n} справа, {rightres}");
        index++;
        i++;
        n++;

    }

    // if (leftres == rightres && tempr == templ)
    // {
    //     Console.WriteLine("число является палиндромом");

    // }

    // else
    // {

    //     Console.WriteLine("число НЕ является палиндромом");
    // }

    for (index = 0; index < count; index++)
    {
        Console.WriteLine(array[index]);
    }
    
   if (array[0] == array[4] && array[1] == array[3]&&array[2] == array[2]) {Console.WriteLine ("палиндром");}
   else {Console.WriteLine("не палиндром");}
}