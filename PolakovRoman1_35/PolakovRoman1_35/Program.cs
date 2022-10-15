double a, b, c;

Console.WriteLine("Введите a");
a = double.Parse(Console.ReadLine());
Console.WriteLine("Введите b");
b = double.Parse(Console.ReadLine());

c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

Console.WriteLine($"Гипотенуза = {c}");