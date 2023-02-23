Console.WriteLine("Введите координаты точки A:");
Console.WriteLine("Введите X1:");
int numX1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y1:");
int numY1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z1:");
int numZ1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты B:");
Console.WriteLine("Введите X2:");
int numX2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y2:");
int numY2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z2:");
int numZ2 = Convert.ToInt32(Console.ReadLine());

double result = Distanse(numX1, numY1, numZ1, numX2, numY2, numZ2);
double abbreviatedResult = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(abbreviatedResult);

double Distanse(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double coordDist = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + +Math.Pow((z1 - z2), 2));
    return coordDist;
}
