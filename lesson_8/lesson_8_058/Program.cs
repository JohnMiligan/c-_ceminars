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

void PrintMatrix(int[,] matrix)
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

int[,] TotalMatrix(int[,] firstMatrix, int[,] secondMatrix, int firstMatrixRows, int secondMatrixColumns)
{
    int[,] totalMatrix = new int[firstMatrixRows, secondMatrixColumns];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            totalMatrix[i, j] = 0;
            for (int m = 0; m < firstMatrix.GetLength(1); m++)
            {
                totalMatrix[i, j] += firstMatrix[i, m] * secondMatrix[m, j];
            }
        }
    }
    return totalMatrix;
}



int firstMatrixRows = Prompt("Введите колличество строк первой матрицы: ");
int firstMatrixColumns = Prompt("Введите колличество столбцов первой матрицы: ");
int[,] firstCreateMatrixRandomNat = CreateMatrixRandomNat(firstMatrixRows, firstMatrixColumns, 1, 10);

int secondMatrixRows = Prompt("Введите колличество строк второй матрицы: ");
int secondMatrixColumns = Prompt("Введите колличество столбцов второй матрицы: ");
int[,] secondCreateMatrixRandomNat = CreateMatrixRandomNat(secondMatrixRows, secondMatrixColumns, 1, 10);

PrintMatrix(firstCreateMatrixRandomNat);
Console.WriteLine();
PrintMatrix(secondCreateMatrixRandomNat);
Console.WriteLine();

if (firstMatrixColumns == secondMatrixRows) 
{
    int[,] totalMatrix = TotalMatrix(firstCreateMatrixRandomNat, secondCreateMatrixRandomNat, firstMatrixRows, secondMatrixColumns);
    PrintMatrix(totalMatrix);
}
else Console.WriteLine("Ошибка");

