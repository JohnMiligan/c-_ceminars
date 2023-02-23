int num = Prompt("Введите пятизначное число:");

if (num > 9999 && num < 100000) Palindrome(num);
else Console.WriteLine("Вы ввели некорректное число");

void Palindrome(int number)
{
    int firstNum = number / 10000;
    int secondNum = (number % 10000) / 1000;
    int fourthNum = (number % 100) / 10;
    int fifthNum = number % 10;
    if (firstNum == fifthNum && secondNum == fourthNum) Console.WriteLine($"{number} -> да");
    else Console.WriteLine($"{number} -> нет");
}


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}