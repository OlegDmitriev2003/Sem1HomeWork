Console.Clear();
Console.Write("Введите число: ");
double Num = double.Parse(Console.ReadLine()!);
if (Num % 2 == 0)
    Console.WriteLine($"{Num} - чётное число");
else
    Console.WriteLine($"{Num} - нечётное число");
