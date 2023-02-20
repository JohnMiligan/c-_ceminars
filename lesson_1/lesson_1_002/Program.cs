Console.WriteLine("Введите первое число:");

int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");

int secondNumber = Convert.ToInt32(Console.ReadLine());

if(firstNumber > secondNumber){
    Console.WriteLine($"Число {firstNumber} больше числа {secondNumber}");
}
else if(firstNumber < secondNumber){
    Console.WriteLine($"Число {secondNumber} больше числа {firstNumber}");
}
else{
    Console.WriteLine("Числа равны");
}