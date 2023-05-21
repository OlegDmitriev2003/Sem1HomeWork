Console.Clear();
int Max = 0;
int A = 0;

Console.Write("Введите первое число: ");
 A = int.Parse(Console.ReadLine()!);
if (Max < A )
    Max = A;
Console.Write("Введите второе число: ");
 A = int.Parse(Console.ReadLine()!);
if (Max < A )
    Max = A;

Console.Write("Введите третье число: ");
 A = int.Parse(Console.ReadLine()!);
if (Max < A )
    Max = A;

Console.WriteLine($"Число {Max} - наибольшее");