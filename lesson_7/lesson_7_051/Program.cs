
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

int DiagonalSumMatrix(int[,] matrix)
{
    int matrixCount = 0;
    int matrixSumResult = 0;
    while (matrixCount < matrix.GetLength(0) && matrixCount < matrix.GetLength(1)) 
    {
        matrixSumResult += matrix[matrixCount, matrixCount];
        matrixCount++;
    }
    return matrixSumResult;
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

int[,] array2d = CreateMatrixRandomNat(matrixRows, matrixColumns, 0, 10);
PrintMarix(array2d);
int diagonalSumMatrix = DiagonalSumMatrix(array2d);
Console.WriteLine();
Console.WriteLine($"Сумма диагональных чисел: {diagonalSumMatrix}");