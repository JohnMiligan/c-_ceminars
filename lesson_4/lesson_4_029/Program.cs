int numMin = Prompt("Введите минимальное значение массива:");
int numMax = Prompt("Введите максимальное значение массива:");
numMax++;


int arrLeng = 8;
int[] result = NewArray(arrLeng, numMin, numMax);
PrintArray(result);



int[] NewArray(int arrLeng, int min, int max)
{
    Random rand = new Random();
    int[] arr = new int[arrLeng];
    for (int i = 0; i < arrLeng - 1; i++)
    {
        arr[i] = rand.Next(min, max);
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]} ");
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("-> [");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write($"{array[i]}, ");
        // if (i < array.Length - 1) Console.Write(", ");
    }
    Console.Write($"{array[array.Length - 1]}");
    Console.Write("]");
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

