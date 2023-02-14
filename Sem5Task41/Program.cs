// №41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// * Пользователь вводит число нажатий, затем программа следит за нажатиями и
// выдает сколько чисел больше 0 было введено.
// Метод ввода количества чисел

int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

// Метод, генерирующий массив
int[] GenArrayDigit(int len)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите число № {i+1}: ");
        arr[i] = int.Parse(Console.ReadLine() ?? "0");
        Console.WriteLine();
    }
    return arr;
}

//Метод, выводящий на печать массив
void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

// Метод подсчета положительных чисел
int GenResalt(int []arr)
{
    int Count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            Count = Count + 1;
        }
    }
    return Count;
}

// Метод вывода результата
void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

int Digit = ReadData("Введите количество чисел: ");
int [] ArrayDigit = GenArrayDigit(Digit);
Print1DArr(ArrayDigit);
int value = GenResalt(ArrayDigit);
PrintData("Количество чисел больше 0: ", value);