Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int result = DiffNum(firstNumber, secondNumber);
if (result == 0) Console.WriteLine($"Число {firstNumber} кратно числу {secondNumber}");
else Console.WriteLine($"Число {firstNumber} не кратно числу {secondNumber}, остаток: {result}");



int DiffNum(int num1,int num2)
{
        return num1 % num2;
}