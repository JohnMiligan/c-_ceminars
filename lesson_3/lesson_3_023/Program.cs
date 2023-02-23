int num = Prompt("Введите натуральное число:");

if (num > 0) SquareNum(num);
else Console.WriteLine("Вы ввели не натуральное число");


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void SquareNum(int num)
{
    int count = 1;
    while (count <= num)
    {
        double square = Math.Pow(count, 3);
        Console.WriteLine($"{count,10} - {square,10}");
        count++;
    }
}
