Console.Clear();
Console.WriteLine($"Возведите число А в натуральную степень B используя цикл");
Console.Write("Введите число A = "); 
double namberA = double.Parse(Console.ReadLine());
Console.Write("Введите число B = "); 
int namberB = int.Parse(Console.ReadLine());
double composition = namberA;

// ! Баловство
//while (composition != Math.Pow(namberA, namberB))
//	composition *= namberA;

for (int i = 1; i < namberB; i++)
	composition *= namberA;

Console.WriteLine($"composition = {composition}");