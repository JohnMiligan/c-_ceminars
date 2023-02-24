int num = Prompt("Введите число:");
int totalSum = SumNumber(num);
Console.WriteLine($"{num} -> {totalSum}");


int SumNumber(int number)
{
    int result = 0;
    while (number > 0)
    {
        int remainder = number % 10;
        number = number / 10;
        result = result + remainder;
    }
    return result;
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}