Console.WriteLine("Введите натуральное число:");
int number = int.Parse(Console.ReadLine());

NaturalNumbers(number);

void NaturalNumbers(int num)
{
    if (num == 0) return;
    NaturalNumbers(num - 1);
    Console.Write($"{num} ");
}