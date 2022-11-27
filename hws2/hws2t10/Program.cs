// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// ​
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("введите трехзначное число");
Int32 data = Convert.ToInt32(Console.ReadLine());
Int32 Mdata = Convert.ToInt32(Math.Abs(data));
if ( Mdata > 99 && data < 1000) {
Int32 gap = Mdata / 10;
Int32 res = gap % 10;
Console.WriteLine(res);
}
else {

    Console.WriteLine("введите трехзначное число");
}

// if (data < 0){
//     Int32 Mdata = -data;
// }
// else {}