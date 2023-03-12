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

double[] AverageColumnMatrix(int[,] matrix, int columns, int rows)
{
    double[] AverageColumnMatrixResult = new double[columns];
    double averageResult = 0;
    for (int matrixRow = 0; matrixRow < matrix.GetLength(1); matrixRow++)
    {
        for (int matrixColumn = 0; matrixColumn < matrix.GetLength(0); matrixColumn++)
        {
            averageResult += matrix[matrixColumn, matrixRow];
        }
        AverageColumnMatrixResult[matrixRow] = averageResult / rows;
        AverageColumnMatrixResult[matrixRow] = Math.Round(AverageColumnMatrixResult[matrixRow], 1, MidpointRounding.ToZero);
        averageResult = 0;
    }
    return AverageColumnMatrixResult;
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

void PrintArray(double[] arr)
{
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}; ");
        else Console.Write($"{arr[i]}.");
    }

}

int matrixRows = Prompt("Введите колличество строк: ");
int matrixColumns = Prompt("Введите колличество столбцов: ");

int[,] array2d = CreateMatrixRandomNat(matrixRows, matrixColumns, 0, 10);
PrintMarix(array2d);
double[] averageColumnMatrix = AverageColumnMatrix(array2d, matrixColumns, matrixRows);
PrintArray(averageColumnMatrix);