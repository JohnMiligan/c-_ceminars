int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

double[] CreateArrRandomDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(arr[i], 1, MidpointRounding.ToZero);
    }
    return arr;
}

void PrintArrayDouble(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}

double ArrayMaxNumber(double[] arr)
{
    double maxArrNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (maxArrNum < arr[i]) maxArrNum = arr[i];
    }
    return maxArrNum;
}

double ArrayMinNumber(double[] arr)
{
    double minArrNum = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (minArrNum > arr[i]) minArrNum = arr[i];
    }
    return minArrNum;
}

int sizeArr = Prompt("Введите длину массива:");
int arrMin = Prompt("Введите минимальное число массива:");
int arrMax = Prompt("Введите максимальное число массива:");
double[] array = CreateArrRandomDouble(sizeArr, arrMin, arrMax);
PrintArrayDouble(array);
double maxNumber = ArrayMaxNumber(array);
double minNumber = ArrayMinNumber(array);
double result = Math.Round(maxNumber - minNumber, 1, MidpointRounding.ToZero);
Console.WriteLine(" -> " + result);
