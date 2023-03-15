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

int[] FindLeastElement(int[,] matrix)
{
    int row = 0;
    int column = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < matrix[row, column])
            {
                row = i;
                column = j;
            }
        }
    }
    return new int[] { row, column };
}


int[,] DeleteLeastElement(int[,] matrix, int[] array, int rows, int columns)
{
    int[,] resultMatrix = new int[rows - 1, columns - 1];
    int m = 0, n = 0;
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        if (m == array[0]) m++;
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            if (n == array[1]) n++;
            resultMatrix[i, j] = matrix[m, n];
            n++;
        }
        m++;
        n = 0;
    }
    return resultMatrix;
}

int matrixRows = Prompt("Введите колличество строк: ");
int matrixColumns = Prompt("Введите колличество столбцов: ");
int[,] createMatrixRandomNat = CreateMatrixRandomNat(matrixRows, matrixColumns, 0, 10);
PrintMatrix(createMatrixRandomNat);
int[] findLeastElement = FindLeastElement(createMatrixRandomNat);
int[,] deleteLeastElement = DeleteLeastElement(createMatrixRandomNat, findLeastElement, matrixRows, matrixColumns);
Console.WriteLine();
PrintMatrix(deleteLeastElement);
