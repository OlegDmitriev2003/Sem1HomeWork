Console.Clear();
Console.Write("Введите первое число: ");
int A = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int B = int.Parse(Console.ReadLine()!);

if (A > B)
    Console.Write($"{A} больше, чем {B} ");
else if (A < B)
    Console.Write($"{B} больше, чем {A}");
else
    Console.Write("Числа равны");