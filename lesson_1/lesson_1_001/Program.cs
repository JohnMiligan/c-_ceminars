Console.WriteLine("Введите число:");

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите степень:");

int degree = Convert.ToInt32(Console.ReadLine());

int exponentiation = number * number;

if(exponentiation == degree){
    Console.WriteLine($"Число {degree} является степенью числа {number}");
}
else{
    Console.WriteLine($"Число {degree} не является степенью числа {number}");
}