// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

Console.WriteLine("Введите координату X:");
int coordX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
int coordY = Convert.ToInt32(Console.ReadLine());

int quarterPlane = Quarter(coordX, coordY);
// Console.WriteLine(quarterPlane);
string result = quarterPlane > 0 
    ? $"Указанные координаты соответствуют четверти {quarterPlane}"
    : "Введены некорректные координаты";
Console.WriteLine(result);

int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
