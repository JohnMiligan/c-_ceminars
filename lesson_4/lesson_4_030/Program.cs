int num = Prompt("Введите количество элементов в массиве:");
int[] result = NewArray(num);
Console.WriteLine("Массив состоит из:");
PrintArray(result);



int[] NewArray(int number)
{
    Random rand = new Random();
    int[] arr = new int[number];
    for (int i = 0; i < number; i++)
    {
        arr[i] = rand.Next(0,2);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}