// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!

Console.WriteLine ("введите число А");
int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("введите степень числа");
int B = Convert.ToInt32(Console.ReadLine());

int i = 1;
int answer = 1;
while (i<=B){

answer = A*answer;
i++;
}
Console.WriteLine ($"{A} в степени {B} равняется {answer}");