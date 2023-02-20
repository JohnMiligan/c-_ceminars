Console.WriteLine("Введите натуральное число:");

int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    int positive = number - (number * 2);
    while (positive <= number)
    {
        Console.WriteLine(positive);
        positive++;
    }
}
else if(number <= 0)
{
   Console.WriteLine("Вы ввели ненатуральное число");
}


