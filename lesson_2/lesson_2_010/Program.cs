Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 1000 && number > 99)
{
    int remainder = number % 100;
    int result = remainder / 10;
    Console.WriteLine(result);
}
else Console.WriteLine("Вы ввели не трехзначное число число");

