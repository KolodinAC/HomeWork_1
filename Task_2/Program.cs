// Напишите программу, которая на вход принимает три числа и выдаёт, какое число максимальное.

Console.WriteLine("Введите три числа для сравнения:");

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = a;

if(a == b | a == c | b == c)
{
    Console.WriteLine("Некоторые числа равны. Перезапустите программу и введети разные числа.");
}
else
{
    if(max > b)
    {
        max = a;
    }
    else
    {
        max = b;
    }
    if(max < c)
    {
        max = c;
    }
    else
    {
        max = a;
    }
    Console.Write("Максимальное число = ");
    Console.Write(max);
    Console.WriteLine(" .");
    Console.Write("Поздравляем, Вы справились !)");
}

