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
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

int InfoAboutMatrixPosition(int[,] matrix, int matrixRowPos, int matrixColumnPos)
{
    int matrixResult = -1;
    for (int matrixRow = 0; matrixRow < matrix.GetLength(0); matrixRow++)
    {
        for (int matrixColumn = 0; matrixColumn < matrix.GetLength(1); matrixColumn++)
        {
            if (matrixRow == matrixRowPos && matrixColumn == matrixColumnPos) matrixResult = matrix[matrixRowPos, matrixColumnPos];
        }
    }
    return matrixResult;
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

int matrixRowPosition = Prompt("Введите номер строки: ");
int matrixColumnPosition = Prompt("Введите номер столбца: ");

int[,] array2d = CreateMatrixRandomNat(3, 4, 0, 10);
PrintMarix(array2d);
int infoAboutMatrixPosition = InfoAboutMatrixPosition(array2d, matrixRowPosition, matrixColumnPosition);
Console.WriteLine();
if (infoAboutMatrixPosition >= 0) Console.WriteLine($"{matrixRowPosition}, {matrixColumnPosition} -> {infoAboutMatrixPosition}");
else Console.WriteLine($"{matrixRowPosition}, {matrixColumnPosition} -> Такого элемента в массиве нет");