// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5


int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[,] CreateMatrixRandomNat(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++) // i < rows - можно еще так
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // i < columns - можно еще так
        {
            matrix[i, j] = i + j;
        }
    }
    return matrix;
}

void PrintMarix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 1}, ");
            else Console.Write($"{matrix[i, j], 1}");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

int matrixRows = Prompt("Введите колличество строк: ");
int matrixColumns = Prompt("Введите колличество столбцов: ");

int[,] array2d = CreateMatrixRandomNat(matrixRows, matrixColumns);
PrintMarix(array2d);