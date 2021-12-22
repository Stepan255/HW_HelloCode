Console.Clear();
Console.WriteLine($"Показывает четные натуральные числа от 2 до N");
Console.Write("Введите натуральное число N = "); 
double namberN = int.Parse(Console.ReadLine());

if(namberN == 1)
{
	Console.WriteLine($"В данном диапазоне нет чётных чисел");
}else
{
	Console.WriteLine($"Четные числа от 2 до {namberN}:");
	double namberOfRow = 2;
	Console.Write($"{namberOfRow}");
	namberOfRow += 2;
	while(namberOfRow <= namberN)
	{
		Console.Write($", {namberOfRow}");
		namberOfRow += 2;
	}
}