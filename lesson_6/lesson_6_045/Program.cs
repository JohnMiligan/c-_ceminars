//Задача 45: Напишите программу,
// которая будет создавать
// копию заданного массива
// с помощью поэлементного
// копирования.

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

int[] CopyArr(int[] arr)
{
    int[] arrCopied = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrCopied[i] = arr[i];
    }
    return arrCopied;
}

int sizeArr = Prompt("Введите длину массива:");
int[] createArrRandomNat = CreateArrRandomNat(sizeArr, 0, 10);
PrinArray(createArrRandomNat);
int[] resultCopyArr = CopyArr(createArrRandomNat);
Console.WriteLine();
PrinArray(resultCopyArr);
