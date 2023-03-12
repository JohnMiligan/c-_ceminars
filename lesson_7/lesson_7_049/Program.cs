int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] CreateMatrixRandomNat(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) // i < rows - можно еще так
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // i < columns - можно еще так
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int[,] SquareMatrix(int[,] matrix)
{
    for (int matrixRow = 0; matrixRow < matrix.GetLength(0); matrixRow += 2)
    {
        for (int matrixColumn = 0; matrixColumn < matrix.GetLength(1); matrixColumn += 2)
        {
            matrix[matrixRow, matrixColumn] *= matrix[matrixRow, matrixColumn];
        }
    }
    return matrix;
}

void PrintMarix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4} ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine();
    }
}

int matrixRows = Prompt("Введите колличество строк: ");
int matrixColumns = Prompt("Введите колличество столбцов: ");

int[,] array2d = CreateMatrixRandomNat(matrixRows, matrixColumns, 1, 5);
PrintMarix(array2d);
int[,] squareMatrix = SquareMatrix(array2d);
Console.WriteLine();
PrintMarix(squareMatrix);