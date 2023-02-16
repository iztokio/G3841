// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом
// столбце.

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
            arr[i, j] = j + i;
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

void PrintStSr(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double res = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            res += arr[i, j];
        }
        Console.Write((res / arr.GetLength(0)) + "\t");
    }
}

int xlen = InputNum("Ваше число столбцов: ");
int ylen = InputNum("Ваше число строк: ");
int[,] matrix = Gen2DArr(xlen, ylen);
Print2DArr(matrix);
Console.WriteLine();
PrintStSr(matrix);