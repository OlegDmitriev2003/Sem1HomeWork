
Console.Clear();
int i = 0;

Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);

while (Num >= i)
{
    if (i % 2 == 0)
        Console.WriteLine(i);
    i++;
}