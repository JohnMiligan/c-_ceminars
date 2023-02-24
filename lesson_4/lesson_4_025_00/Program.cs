int num = Prompt("Введите число:");

int sumResult = QuantityNumbers(num);
Console.WriteLine($"{num} -> {sumResult}");

int QuantityNumbers(int num)
{
    int result = 0;
    while (num != 0)
    {
        num = num / 10;
        result++;
    }
    return result;
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}