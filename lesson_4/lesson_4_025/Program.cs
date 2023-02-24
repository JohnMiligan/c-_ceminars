
int num = Prompt("Введите число:");
int numSquare = Prompt("Введите степень числа:");

if (numSquare > 0)
{
    int total = SquareNum(num, numSquare);
    Console.WriteLine($"Число {num} в степени {numSquare} равняется: {total}");
}
else Console.WriteLine("Вы ввели не натуральное число степени");



int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int SquareNum(int number, int squar)
{
    int count = 2; // счетчик начинается с 2, т.к. мы сразу умножаем 2 числа между собой из необходимого кол-ва (squar)
    int result = number;
    while (count <= squar)
    {
        result = result * number;
        count++;
    }
    return result;
}