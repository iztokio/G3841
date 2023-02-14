// №25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в
// натуральную степень B.

//Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

//Выводим результат пользователю
void PrintData(string msg1, int msg2)
{
    Console.Write(msg1);
    Console.Write(msg2);
}

int Pow(int a, int b)
{
    int res = 1;
    while (b > 0)
    {
        b = b - 1;
        res = res * a;
    }
    return res;
}

int a = ReadData("Введите число A");
int b = ReadData("Введите число B");

int res = Pow(a, b);

PrintData($"Число {a} в степени {b} равно: ", res);