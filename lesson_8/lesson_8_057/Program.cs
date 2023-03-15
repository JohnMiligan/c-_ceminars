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

int[] ConvertMatrixToArray(int[,] matrix, int rows, int columns)
{
    int[] array = new int[rows * columns];
    int count = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count++;
        }
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

void SumElemArray(int[] array)
{
    int count = 1;
    int currentNumber = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] == currentNumber) count++;
        else 
        {
            Console.WriteLine($"Чисел {array[i-1]} в массиве содержится: {count}");
            currentNumber = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"Чисел {currentNumber} в массиве содержится: {count}");
}


int matrixRows = Prompt("Введите колличество строк: ");
int matrixColumns = Prompt("Введите колличество столбцов: ");
int[,] createMatrixRandomNat = CreateMatrixRandomNat(matrixRows, matrixColumns, 0, 5);
PrintMatrix(createMatrixRandomNat);
Console.WriteLine();
int[] convertMatrixToArray = ConvertMatrixToArray(createMatrixRandomNat, matrixRows, matrixColumns);
Array.Sort(convertMatrixToArray);
PrintArray(convertMatrixToArray);
Console.WriteLine();
SumElemArray(convertMatrixToArray);
