
Console.WriteLine("Введите натуральное число:");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите натуральное число:");
int secondNumber = int.Parse(Console.ReadLine());

NaturalNumbers(firstNumber, secondNumber);

void NaturalNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        NaturalNumbers(num1 - 1, num2);
        Console.Write($"{num1} ");
    }
    else if (num2 > num1)
    {
        NaturalNumbers(num1, num2 - 1);
        Console.Write($"{num2} ");
    }
    else Console.Write($"{num2} ");
}