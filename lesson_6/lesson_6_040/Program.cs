int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int firstSide = Prompt("Введите длину первой стороны треугольника:");
int secondSide = Prompt("Введите длину второй стороны треугольника:");
int thirdSide = Prompt("Введите длину третьей стороны треугольника:");

if (firstSide > secondSide + thirdSide 
|| secondSide > firstSide + thirdSide 
|| thirdSide > secondSide + firstSide) Console.WriteLine("Нет");
else Console.WriteLine("Да");
