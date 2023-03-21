Console.WriteLine("Введите натуральное число:");
int firstNumber = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа:");
int secondNumber = int.Parse(Console.ReadLine());
int result = firstNumber * firstNumber;

int SumNumbers(int num, int deg)
{
   if (deg == 0) return 1;
   else return num * SumNumbers(num, deg - 1);
}
Console.WriteLine($"{firstNumber}, {secondNumber} => {SumNumbers(firstNumber, secondNumber)}");