Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000)
{
    int result = number % 10;
    Console.WriteLine(result);
}
else if (number > 999)
{
    while (number > 999)
    {
        number = number / 10;
    }
    int division = number % 10;
    Console.WriteLine(division);
}
else Console.WriteLine("Третьей цифры нет");

