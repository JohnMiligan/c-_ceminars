// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int num = Prompt("Введите натуральное число:");
int sumResult = SumGradation(num);
Console.WriteLine($"{num} -> {sumResult}");

int SumGradation(int naturalNum)
{
    int result = 0;
    for (int i = 0; i <= naturalNum; i++)
    {
        result = result + i;
    }
    return result;
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
