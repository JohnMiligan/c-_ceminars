
int Prompt(string message)
{
    Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] FibonacciArray(int num)
{
    int[] fibArr = new int[num];
    fibArr[0] = 0;
    if (num > 1) fibArr[1] = 1;
    for (int i = 2; i < num; i++)
    {
        fibArr[i] = fibArr[i - 1] + fibArr[i - 2];
    }
    return fibArr;
}

void PrinArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {

        Console.Write($"{arr[i]} ");
    }

}

int number = Prompt("введите натуральное число:");
int[] resultArray = FibonacciArray(number);
PrinArray(resultArray);
