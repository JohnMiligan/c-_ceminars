// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты A:");
int numX1 = Convert.ToInt32(Console.ReadLine());
int numY1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты B:");
int numX2 = Convert.ToInt32(Console.ReadLine());
int numY2 = Convert.ToInt32(Console.ReadLine());

double result = Distanse(numX1, numY1, numX2, numY2);
double abbreviatedResult = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(abbreviatedResult);

double Distanse(int x1, int y1, int x2, int y2)
{
    double coordDist = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
    return coordDist;
}


