Console.WriteLine("Введите натуральное число:");
int firstNumber = int.Parse(Console.ReadLine());

int SumNumbers(int num)
{
    if (num == 0) return 0;
    else return num % 10 + SumNumbers(num / 10);
}
Console.WriteLine(SumNumbers(firstNumber));
