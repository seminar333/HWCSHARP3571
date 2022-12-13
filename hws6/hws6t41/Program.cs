// первый вариант решения через массив. Думал еще третий вариант через сложение строк,но не нашел метод как в сложенных строках разделить элементы. потом же их снова в массив загонять, получается мало чем от первого способа отличается.


void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {

        int N;
        string stopWord = "stop"; 
        Console.WriteLine($"Введите число № {index + 1}:");
        string str = Console.ReadLine();// что здесь не нравится?
        bool res = int.TryParse(str, out N);

        if (res == true)
        {

            array[index] = N;
            index++;
            if (str == stopWord) { break; }

        }
        else
        {
            
            break;//как сделать чтобы здесь условие возвращало последнее неправильно введенное число обатно в цикл для повторного ввода? сейчас просто прерываем цикл.уже наверно будет не void метод?
// пробовал здесь Console.WriteLine ("введите число" + (index+1) +"заново") перестает работать stopWord.
        }
    }
}
void PrintArray(int[] arr)
{
    int count = arr.Length;
    int index = 0;
    while (index < count)
    {
        Console.Write(arr[index] + " ");
        index++;
    }
}

int[] array = new int[10];//колличество элементов может быть огромным, но для проверки хватит и 10

FillArray(array);
Console.Write("вы ввели: ");
PrintArray(array);
int res = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        res += 1;
    }
}
Console.WriteLine(" ");

Console.WriteLine($"из них чисел больше 0 = {res}");



// второй вариант решения где стоп слово является число 0,1.

// string stringName = "";

// double userData = 0;
// int count = 0;
// int n = 0;

// do
// {
//     Console.Write("Введите любое число и нажмите клавишу Enter: ");
//     userData = Convert.ToDouble(Console.ReadLine());
//     count++;
//     Console.WriteLine("Пользователь ввел число: " + userData);
//     if (userData > 0)
//     {
//         n++;
//     }


// } while ( userData != 0.1);

// Console.WriteLine($"колличество чисел которое ввел пользователь  {count - 1}");
// Console.WriteLine($"колличество чисел больше нуля  {n}");