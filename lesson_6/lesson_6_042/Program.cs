int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int TransformationNumber(int num)
{
    int count = 1;
    int result = 0;
    while (num > 0)
    {
        result = result + num % 2 * count;
        num = num / 2;
        count *= 10;
    }
    return result;
}

int number = Prompt("Введите число:");
int transformationNumber = TransformationNumber(number);
Console.WriteLine($"{number} -> {transformationNumber}");