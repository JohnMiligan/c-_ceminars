
int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double[,] CreateMatrixRandomNat(int rows, int columns, double min, double max)
{
    double[,] matrix = new double[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // i < rows - можно еще так
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // i < columns - можно еще так
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
            matrix[i, j] = Math.Round(matrix[i, j], 1, MidpointRounding.ToZero);
        }
    }
    return matrix;
}

void PrintMarix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
             Console.Write($"{matrix[i, j], 6} ");
        }
        Console.WriteLine();
    }
}

int matrixRows = Prompt("Введите колличество строк: ");
int matrixColumns = Prompt("Введите колличество столбцов: ");

double[,] array2d = CreateMatrixRandomNat(matrixRows, matrixColumns, -10, 10);
PrintMarix(array2d);