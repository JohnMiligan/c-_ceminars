int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateArrRandomNat(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrinArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");

}

int FindSum(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum = sum + arr[i];

    }
    return sum;
}


int sizeArr = Prompt("Введите длину массива:");
int arrMin = Prompt("Введите минимальное число массива:");
int arrMax = Prompt("Введите максимальное число массива:");
int[] array = CreateArrRandomNat(sizeArr, arrMin, arrMax);
PrinArray(array);
int result = FindSum(array);
Console.Write($" -> {result}");