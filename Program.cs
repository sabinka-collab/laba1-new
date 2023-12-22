Console.WriteLine("Введите время в секундах");
int t = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите ускорение");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите скорость в начальный момент времени");
int v = Convert.ToInt32(Console.ReadLine());
double s = v * t + (a * Math.Pow(t, 2)) / 2;
Console.WriteLine($"Путь будет равен {s}");
