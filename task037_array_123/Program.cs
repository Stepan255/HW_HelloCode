Console.Clear();
Console.WriteLine("В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]");

int[] array = new int[123];
int count = 0;

for (int i = 0; i < array.Length; i++)
{
	array[i] = new Random().Next(0, 200);
	if (10 <= array[i] && array[i] <=99) 
	{
		count += 1;
		Console.WriteLine($"{count}. {array[i]}");
	}
}

Console.WriteLine($"количество элементов из отрезка [10,99] = {count}");