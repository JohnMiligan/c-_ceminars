Console.WriteLine("Введите натуральное число:");

int number = Convert.ToInt32(Console.ReadLine());

int count = 2;


    while (count<=number)
{
    if(count % 2 == 0){
    Console.WriteLine(count);
    count = count + 2;
    }
    else{
        count = count + 2;
    }
}
