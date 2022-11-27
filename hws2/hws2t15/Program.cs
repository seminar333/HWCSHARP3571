// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// ​
// 6 -> да
// 7 -> да
// 1 -> нет


Console.WriteLine ("введите число от 1 до 7");
Int32 data = Convert.ToInt32(Console.ReadLine());

if (data == 1) Console.WriteLine ("Понедельник");

if (data == 2) Console.WriteLine ("Вторник");

if (data == 3) Console.WriteLine ("Среда");

if (data == 4) Console.WriteLine ("Четверг");

if (data == 5) Console.WriteLine ("Пятница, УРА завтра суббота");

if (data == 6) Console.WriteLine ("Шаббат, УРА выходной!!!");

if (data == 7) Console.WriteLine ("Воскресние, УРА выходной!!!");


if (data == 6 || data == 7) Console.WriteLine ("БЫЛ!!! До рождения двоих детей В-))");
