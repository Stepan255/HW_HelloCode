Console.Clear();
Console.Write("Введите число: ");
double namberNoString = double.Parse(Console.ReadLine());
double powOfNamber = Math.Pow(namberNoString, 2.0);
Console.Write($"Квадрат числа {namberNoString} = {powOfNamber}");