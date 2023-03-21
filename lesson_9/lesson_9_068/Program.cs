
Console.WriteLine("Введите натуральное число:");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Введите натуральное число:");
int secondNumber = int.Parse(Console.ReadLine());

int ackerman = Ackerman(firstNumber, secondNumber);
if (ackerman >= 0) Console.WriteLine(ackerman);
else Console.WriteLine("Ошбика! Числа должны быть больше нуля");

int Ackerman(int num1, int num2)
{
    if (num1 == 0) return num2 + 1;

    else if (num1 > 0 && num2 == 0) return Ackerman(num1 - 1, 1);

    else if (num1 > 0 && num2 > 0) return Ackerman(num1 - 1, Ackerman(num1, num2 - 1));
    else return -1;
}



