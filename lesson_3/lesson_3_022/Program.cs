// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4



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
        double square = Math.Pow(count, 2);
        Console.WriteLine($"{count,5} - {square,5}");
        count++;
    }
}

