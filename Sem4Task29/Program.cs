// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// * Ввести с клавиатуры длину массива и диапазон значений элементов 

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[] GenArr(int num, int begin, int end)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(begin, end);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

int LenArr = ReadData("Введите длину массива.");
int Begin = ReadData("Введите начало диапазона значений массива.");
int End = ReadData("Введите конец диапазона значений массива.");

int[] arr = GenArr(LenArr, Begin, End);

PrintArr(arr);