
Console.WriteLine("Введите трехзначное число:");

int number = Convert.ToInt32(Console.ReadLine());

if(number >= 100 && number <= 999){
    int last = number % 10;
    Console.WriteLine($"Последняя цифра числа {number} - {last}");
}
else{
    Console.WriteLine("Вы ввели неверное число");
}