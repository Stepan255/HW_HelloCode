// Даны два числа. Показать большее и меньшее число
Console.Clear();
double namberA = new Random().Next(1, 1000);
double namberB = new Random().Next(1, 1000);
if (namberA == namberB)
{
	Console.WriteLine($"{namberA} = {namberB}");
}else if(namberA > namberB)
{
	Console.WriteLine($"max = {namberA}");
	Console.Write($"min = {namberB}");
}else
{
	Console.WriteLine($"max = {namberB}");
	Console.Write($"min = {namberA}");
}
