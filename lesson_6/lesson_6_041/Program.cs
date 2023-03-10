int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateArr(int num)
{
    int[] filledArr = new int[num];
    for (int i = 0; i < num; i++)
    {
        Console.WriteLine($"Введите число номер {i}");
        filledArr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return filledArr;
}

void PrinArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write(" -> ");

}

int NumbersAboveZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int number = Prompt("Введите количество чисел:");
int[] createArr = CreateArr(number);
PrinArray(createArr);
int result = NumbersAboveZero(createArr);
Console.Write(result);

