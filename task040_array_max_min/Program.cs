Console.Clear();
Console.WriteLine($"В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом");
Console.Write("Введите длинну массива: ");
int length = int.Parse(Console.ReadLine());
if (length >= 1)
{
	double[] array = new double[length];

	int rangeMin = -1000;
	int rangeMax = 1000;
	double min = rangeMax + 2;
	double max = rangeMin - 2;
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = Math.Round(new Random().NextDouble(), 2) + new Random().Next(rangeMin, rangeMax);
		if (array[i] > max) max = array[i];
		if (array[i] < min) min = array[i];
		Console.WriteLine($"{i}. {array[i]}");
	}
	Console.WriteLine($"Hазница между максимальным и минимальным элементом данного массива составляет {max - min}");
}else 
Console.WriteLine("Число маловато");