Console.WriteLine("Введите номер четверти от 1 до 4:");
string planeNumber = Console.ReadLine();

string planeCoords = Quarter(planeNumber);
Console.WriteLine($"Овет по диапозону: {planeCoords}");

string Quarter(string plane)
{
    if (plane == "1") return "x > 0, y > 0";
    if (plane == "2") return "x < 0, y > 0";
    if (plane == "3") return "x < 0, y < 0";
    if (plane == "4") return "x > 0, y < 0";
    return "Введено некорректное число";
}
