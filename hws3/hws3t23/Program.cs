// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


Console.WriteLine ("введите число N");
int N = Convert.ToInt32(Console.ReadLine());
int k = 1;
for (int i =1; i<=N;  i++){

k=i*i*i;
Console.WriteLine(k);

}