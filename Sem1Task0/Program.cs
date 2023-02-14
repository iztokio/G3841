//Задача №0
//Пишем программу , которая умножает число само на себя

//Считаем данные с консоли
string? inputNum = Console.ReadLine();

//Проверяем чтобы данные были не пустыми
if (inputNum != null)
{
    //Парсим введенное число
    int number = int.Parse(inputNum);
    //Находим квадрат числа
    //int result = number*number;
    int result = (int)Math.Pow(number, 2);

    //Выводим данные в консоль
    Console.WriteLine(result);

}
