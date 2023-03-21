Console.WriteLine("Введите натуральное число:");
int number = int.Parse(Console.ReadLine());

if (number > 0) 
{
    Console.Write($"{number} -> ");
    NaturalNumbers(number);
}
else Console.WriteLine("Ошибка, числа должны быть больше нуля!");


void NaturalNumbers(int num)
{
    if (num == 0) return;
    else if (num == 1) Console.Write($"{num}");
    else
    {
        Console.Write($"{num}, ");
        NaturalNumbers(num - 1);
    }
}
