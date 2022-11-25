// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите два числа для сравнения:");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int max = a;

if(a == b)
{
    Console.WriteLine("Числа равны. Перезапустите программу и введети разные числа.");
}
else
{
    if(a > b)
    {
        max = a;
        Console.Write("Первое число ");
        Console.Write(max);
        Console.Write(" больше второго числа ");
        Console.Write(b);
    }
    else
    {
        max = b;
        Console.Write("Второе число ");
        Console.Write(max);
        Console.Write(" больше первого числа ");
        Console.Write(a);
    }
}