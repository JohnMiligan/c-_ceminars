Console.WriteLine("Введите первое число:");
int firstNumber = Convert.ToInt32(Console.ReadLine());

if(CheckNumber(firstNumber)) Console.WriteLine("Да");
else Console.WriteLine("Нет");

bool CheckNumber(int num)
{
return num % 7 == 0 && num % 23 == 0;

}