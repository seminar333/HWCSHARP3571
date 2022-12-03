// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53


Console.WriteLine ("введите ХА");
int XA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите YA");
int YA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите ZA");
int ZA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("введите ХB");
int XB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите YB");
int YB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите ZB");
int ZB = Convert.ToInt32(Console.ReadLine());

double res = Convert.ToDouble (Math.Sqrt(Math.Pow((XA-XB),2) + Math.Pow((YA-YB),2) + Math.Pow((ZA-ZB),2)));

Console.WriteLine ($"{res:f2}");