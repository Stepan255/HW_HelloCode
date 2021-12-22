Console.Clear();
Console.WriteLine("Вводится 3 числа из них находится максимум.");

List<int> arrayOfNamber = new List<int>();

Console.Write("Введите первое число: ");
arrayOfNamber.Add(int.Parse(Console.ReadLine()));
Console.Write("Введите второе число: ");
arrayOfNamber.Add(int.Parse(Console.ReadLine()));
Console.Write("Введите третье число: ");
arrayOfNamber.Add(int.Parse(Console.ReadLine()));

int maxValue = arrayOfNamber.Max();

Console.WriteLine(maxValue);