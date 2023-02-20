Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число:");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (CheckDegree(firstNumber, secondNumber)) Console.WriteLine("Да");
else Console.WriteLine("Нет");

bool CheckDegree(int degree1, int degree2)
{
    
    return degree1 == degree2 * degree2 || degree2 == degree1 * degree1;
}

// int degree = 0;
// int result = 0;

// if (firstNumber < secondNumber) 
// {
//     degree = firstNumber;
//     result = secondNumber;
// }
// else
// {
//     degree = secondNumber;
//     result = firstNumber;
// }

// int checkNumber = CheckDegree(degree);
// if(checkNumber == result) Console.WriteLine($"{firstNumber},{secondNumber} -> Да");
// else Console.WriteLine($"{firstNumber},{secondNumber} -> Нет");

// int CheckDegree(int deg)
// {
//     return deg * deg;
// }
