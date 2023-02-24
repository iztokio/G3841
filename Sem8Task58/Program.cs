// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

// Чтение данных из консоли
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}

// Заполняем массив случайными числами
int[,] Gen2DArray(int raw, int col, int min, int max)
{
    int[,] matr = new int[raw, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }
    }
    return matr;
}

// Печать двумерного массива
void Print2DArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

// метод для умножения матриц
int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
   
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        throw new ArgumentException("Матрицы не могут быть умножены");
    }
  
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            matrixC[i, j] = sum;
        }
    }

    return matrixC;
}

    int m1 = ReadData("Введите количество строк M1: ");
    int n1 = ReadData("Введите количество столбцов N1: ");

    int m2 = ReadData("Введите количество строк M2: ");
    int n2 = ReadData("Введите количество столбцов N2: ");

    int[,] matrix1 = Gen2DArray(m1, n1, 0, 9);
    int[,] matrix2 = Gen2DArray(m2, n2, 0, 9);

    Print2DArray(matrix1);
    Print2DArray(matrix2);

    Print2DArray(MultiplyMatrices(matrix1, matrix2));