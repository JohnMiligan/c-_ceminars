int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int firstNumber = (number / 100) * 10;
int secondNumber = number % 10;
int finalNumber = firstNumber + secondNumber;
Console.WriteLine();
Console.WriteLine(finalNumber);
