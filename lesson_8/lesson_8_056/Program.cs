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

int[] RowSum(int[,] matrix)
{
    int rowSum = 0;
    int[] allRowSum = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSum += matrix[i, j];
        }
        allRowSum[i] = rowSum;
        rowSum = 0;
    }
    return allRowSum;
}

int MinRowSum(int[] array)
{
    int count = 0;
    int minRowSum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (minRowSum > array[i])
        {
            minRowSum = array[i];
            count = i + 1;
        }
    }
    return count;
}

int matrixRows = Prompt("Введите колличество строк: ");
int matrixColumns = Prompt("Введите колличество столбцов: ");
int[,] createMatrixRandomNat = CreateMatrixRandomNat(matrixRows, matrixColumns, 0, 10);
PrintMatrix(createMatrixRandomNat);
int[] rowSum = RowSum(createMatrixRandomNat);
int result = MinRowSum(rowSum);
if (result == 0) Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result + 1}");
else Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result}");
