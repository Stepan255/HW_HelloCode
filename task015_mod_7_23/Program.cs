Console.Clear();
Console.WriteLine("Определяет кратно ли число 7 и 23");
Console.Write("Введите значение N: "); 
int namberA = int.Parse(Console.ReadLine());

if (namberA == 0)
{
	Console.WriteLine($"Число {namberA} равно 0");
}else if (namberA % 7 == 0 && namberA % 23 == 0)
{
	Console.WriteLine($"Число {namberA} кратно 7 и 23");
}else
{
	Console.WriteLine($"Число {namberA} не кратно 7 и 23");
}