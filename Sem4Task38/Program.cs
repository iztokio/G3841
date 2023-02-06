// №38 Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.

double[] Gen1DArray(int len, int minValue, int maxValue)
{
    double[] arr = new double[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1) + 0.0;
    }
    return arr;
}

void Print1DArr(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

double MinMax(double[] arr)
{
    double max = double.MinValue;
    double min = double.MaxValue;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return (max - min);
}

void PrintData(string res, double value)
{
    Console.WriteLine(res + value);
}

double[] Arr = Gen1DArray(9, 0, 99);
Print1DArr(Arr);
double value = MinMax(Arr);
PrintData("Разница между максимальным и минимальным элементом массива: ", value);