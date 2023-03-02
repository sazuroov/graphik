Console.WriteLine($"Введите a");

int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите b");

int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Введите c");

int c = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите последний промежуток");

int d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите х");

int x = Convert.ToInt32(Console.ReadLine());

for (d++; d < 2; d++)
{
    Console.WriteLine($"{a* Math.Pow(x , x) * b * x + c}");
    Console.Write($"{x}:");
    
}

