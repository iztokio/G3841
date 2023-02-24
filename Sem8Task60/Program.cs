// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
int[,,] Gen3DArray(int x, int y, int z, int min, int max)
{
    int[,,] mass = new int[x, y, z];
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                mass[i, j, k] = new Random().Next(min, max + 1);
            }

        }
    }
    return mass;
}

// Печать трехмерного массива
void Print3DArray(int[,,] mass)
{
    for (int i = 0; i < mass.GetLength(0); i++)
    {
        for (int j = 0; j < mass.GetLength(1); j++)
        {
            for (int k = 0; k < mass.GetLength(2); k++)
            {
                Console.Write($"{mass[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

    int x = ReadData("Введите количество цифр по оси X: ");
    int y = ReadData("Введите количество цифр по оси Y: ");
    int z = ReadData("Введите количество цифр по оси Z: ");

    int[,,] mass = Gen3DArray(x, y, z, 10, 99);

    Print3DArray(mass);