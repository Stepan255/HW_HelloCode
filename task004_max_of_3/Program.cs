Console.Clear();
Console.WriteLine("Вводится 3 числа из них находится максимум.");

Console.Write("Введите первое число: ");
int namberA = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int namberB = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int namberC = int.Parse(Console.ReadLine());

int[] arrayOfNamber = {namberA, namberB, namberC};

int maxValue = arrayOfNamber.Max();

Console.WriteLine($"max = {maxValue}");