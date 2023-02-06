// №36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.

int[] Gen1DArray(int len, int minValue, int maxValue)
{
    int[] arr = new int[len];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(minValue, maxValue + 1);
    }
    return arr;
}

void Print1DArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + "]");
}

int SumPos(int[] arr)
{
    int res = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        res+=arr[i];
    }
    return res;
}

void PrintData(string res, int value)
{
    Console.WriteLine(res + value);
}

int[] Arr = Gen1DArray(9, 0, 99);
Print1DArr(Arr);
int value = SumPos(Arr);
PrintData("Cуммa элементов, стоящих на нечётных позициях: ", value);