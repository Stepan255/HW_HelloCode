// Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива
Console.Clear();
Console.WriteLine("Задать массив из 12 элементов, заполненных числами из [0,9]. Найти сумму положительных/отрицательных элементов массива");

int[] array = new int[12];

int sumPlus = 0;
int sumMinus = 0;
for (int i = 0; i < array.Length; i++)
{
	array[i] = new Random().Next(-9, 10);
	Console.WriteLine($"array [{i}] = {array[i]}");
	if (array[i] > 0)
	{
		// sumPlus += array[i];
		sumPlus = sumPlus + array[i];
	}
	else
	{
		sumMinus += array[i];
	}
}

Console.WriteLine($"Сумма положительных элементов массива равна = {sumPlus}");
Console.WriteLine($"Сумма отрицательных элементов массива равна = {sumMinus}");