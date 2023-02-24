
int num = Prompt("Введите натуральное число:");
int sumResult = SumGradation(num);
Console.WriteLine($"{num} -> {sumResult}");

int SumGradation(int naturalNum)
{
    int result = 1;
    for (int i = 1; i <= naturalNum; i++)
    {
        result = result * i;
    }
    return result;
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}