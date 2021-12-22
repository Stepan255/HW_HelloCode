Console.Clear();
Console.WriteLine("Определяет является ли число четным");
Console.Write("Введите значение a: "); 
int namberA = int.Parse(Console.ReadLine());

if (namberA == 0)
{
	Console.WriteLine($"Число {namberA} равно 0");
}else if (namberA % 2 == 0)
{
	Console.WriteLine($"Число {namberA} четное");
}else
{
	Console.WriteLine($"Число {namberA} нечетное");
}