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


int[] GetReverseArr(int[] arr)
{

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
    return arr;
}
// int[] GetReverseArr( int[] arr, int size)
// {
//     int[] arrayRes = new int[size];
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (arr[i] > 0) arrayRes[i] = arr[i] - arr[i]*2;
//         else arrayRes[i] = arr[i] - arr[i]*2;
//     }
//     return arrayRes;
// }

int sizeArr = Prompt("Введите длину массива:");
int arrMin = Prompt("Введите минимальное число массива:");
int arrMax = Prompt("Введите максимальное число массива:");



int[] array = CreateArrRandomNat(sizeArr, arrMin, arrMax);
PrinArray(array);
Console.Write(" -> ");
int[] reverseArr = GetReverseArr(array);
PrinArray(reverseArr);


