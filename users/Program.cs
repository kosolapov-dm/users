using System.Runtime.ExceptionServices;
Console.WriteLine("Посчитать среднее арифметическое - 1 \n" +
    "Показать данные пользователя - 2");
string task = Console.ReadLine();
if (task == "1")
{
    try
    {
        Console.WriteLine("Введите первое число: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите второе число: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите третье число: ");
        int num3 = int.Parse(Console.ReadLine());

        int[] arr = { num1, num2, num3 };
        int sum = (num1 + num2 + num3) / arr.Length;

        Console.WriteLine($"{sum}");

    }

    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}

if (task == "2")
{
    try
    {
        Console.WriteLine("Введите имя 1: ");
        string name1 = Console.ReadLine();
        Console.WriteLine("Введите год рождения 1: ");
        string date1 = Console.ReadLine();

        Console.WriteLine("Введите имя 2: ");
        string name2 = Console.ReadLine();
        Console.WriteLine("Введите год рождения 2: ");
        string date2 = Console.ReadLine();

        Console.WriteLine("Введите имя 3: ");
        string name3 = Console.ReadLine();
        Console.WriteLine("Введите год рождения 3: ");
        string date3 = Console.ReadLine();

        string[,] users = { { name1, date1 }, { name2, date2 }, { name3, date3 } };

        Console.WriteLine("Вывести данные пользователя (1/2/3):");
        int userid = int.Parse(Console.ReadLine());
        Console.WriteLine($"{users[userid - 1, 0]} {users[userid - 1, 1]}");

    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
};
