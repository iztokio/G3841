// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:

int InputNum(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int[,] Gen2DArr(int xlen, int ylen)
{
    int[,] arr = new int[ylen, xlen];
    for (int i = 0; i < ylen; i++)
    {
        for (int j = 0; j < xlen; j++)
        {
            arr[i, j] = j+i;
        }
    }
    return arr;
}

void Print2DArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}

double GetArrayValue(int[,] arr, int x, int y)
{
    if (x < arr.GetLength(1) && y < arr.GetLength(0))
    {
        return arr[y, x];
    }
    else
    {
        Console.WriteLine("Нет такого элемента");
        return 0;
    }
}

int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] matrix = Gen2DArr(xlen, ylen);
Print2DArr(matrix);
int x = InputNum("Введите координату x: ");
int y = InputNum("Введите координату y: ");
double value = GetArrayValue(matrix, x, y);
Console.WriteLine("Значение элемента: " + value);
