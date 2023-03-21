
Console.WriteLine("Введите натуральное число:");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите натуральное число:");
int secondNumber = int.Parse(Console.ReadLine());

int temp = 0;
if (firstNumber < secondNumber) 
{
    temp = firstNumber;
    firstNumber = secondNumber;
    secondNumber = temp;
}

int result = 0;
if (firstNumber > 0 && secondNumber > 0)
{
    int sumNatNumbers = SumNaturalNumbers(firstNumber, secondNumber);
    Console.WriteLine($"{firstNumber}, {secondNumber} -> {sumNatNumbers}");
}
else Console.WriteLine("Ошибка, числа должны быть больше нуля!");

int SumNaturalNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        return num1 + SumNaturalNumbers(num1 - 1, num2);
    }
    else return num1;
}
