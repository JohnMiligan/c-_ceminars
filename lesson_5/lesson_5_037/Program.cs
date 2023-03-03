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

int[] GetArrNumbersMulti(int[] arr)
{
    if (arr.Length % 2 == 0)
    {
        int[] resultArray = new int[arr.Length / 2];
        int lastNum = arr.Length - 1;
        for (int i = 0; i < arr.Length / 2; i++)
        {
            resultArray[i] = arr[i] * arr[lastNum];
            lastNum--;
        }
        return resultArray;
    }
    else
    {
        int arrCenter = arr.Length / 2;
        int[] resultArray = new int[arr.Length / 2 + 1];
        int lastNum = arr.Length - 1;
        for (int i = 0; i < arr.Length / 2; i++)
        {
            resultArray[i] = arr[i] * arr[lastNum];
            lastNum--;
        }
        resultArray[resultArray.Length - 1] = arr[arrCenter];
        return resultArray;
    }
}


int sizeArr = Prompt("Введите длину массива:");
int arrMin = Prompt("Введите минимальное число массива:");
int arrMax = Prompt("Введите максимальное число массива:");

int[] array = CreateArrRandomNat(sizeArr, arrMin, arrMax);
PrinArray(array);
Console.Write(" -> ");
int[] arrNumbersMulti = GetArrNumbersMulti(array);
PrinArray(arrNumbersMulti);