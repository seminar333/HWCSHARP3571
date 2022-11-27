// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// ​
// 645 -> 5
// ​
// 78 -> третьей цифры нет
// ​
// 32679 -> 6


// Чуть усложнил задачу, ввел рандомное число из интервала +-Int32 и добавил возможность поиска любой цифры в получившимся числе.

Console.WriteLine("введите порядковый номер цифры, которую хотите увидеть");
int data = Convert.ToInt32(Console.ReadLine());

Int32 a = Int32.MinValue;
Int32 b = Int32.MaxValue;

Int32 number = new Random().Next(a, b); 
Console.Write("рандомное число   ");
Console.WriteLine(number);

Int32 Mnumber = Convert.ToInt32(Math.Abs(number)); //если число отрицательное, то и цифру отрицательную выдает
Console.Write("Модуль рандомного числа ");
Console.WriteLine(Mnumber);

Int32 count = 0;

Int64 res = 1; // Int64, потому что res может получиться на 1 порядок больше Int32


while (Mnumber - res >= 0)
{

    res = res * 10;

    count = count + 1;

}

Console.Write("порядок рандомного числа  "); 
Console.WriteLine(count);

if (count >= data)
{

    Int32 gap = Convert.ToInt32(Math.Pow(10, count - data));

    int answergap = Mnumber / gap;

    int answer = answergap % 10;

    Console.Write("Цифра, которую хотел увидеть   ");
    Console.WriteLine(answer);

}

else
{

    Console.WriteLine("фортуна подвела, попробуй еще раз! Порядкого номера цифры в числе не существует");
}
