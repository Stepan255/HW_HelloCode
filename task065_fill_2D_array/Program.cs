// TODO Спирально заполнить двумерный массив
Console.Clear();

void PrintArray(int[,] printArray)
{
	Console.WriteLine();
	for (int i = 0; i <= printArray.GetUpperBound(0); i++)
	{
		for (int j = 0; j <= printArray.GetUpperBound(1); j++)
			Console.Write($"{"|", 5}{printArray[i, j], 5}");
		Console.WriteLine();
	}
}

Console.WriteLine("Спирально заполнить двумерный массив");
Console.Write("Введите количество строк массива: m = ");
int lengthM = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк массива: n = ");
int lengthN = int.Parse(Console.ReadLine());

int[,] array = new int[lengthM, lengthN];
int count = 0;

int offsetTop = 0;
int offsetRight = 0;
int offsetBottom = 0;
int offsetLeft = 0;

while(offsetLeft + offsetRight <= array.GetUpperBound(1) || offsetTop + offsetBottom <= array.GetUpperBound(0))
{
	if (offsetTop + offsetBottom <= array.GetUpperBound(0))
	{
		for (int i = offsetLeft; i <= array.GetUpperBound(1) - offsetRight; i++)
		{
			count += 1;
			Console.Write($"{offsetTop},{offsetBottom},{i};");
			array[offsetTop, i] = count;
			Console.Write($"offsetTop = {offsetTop},{count};");
		}
		offsetTop += 1;
	}

	if (offsetLeft + offsetRight <= array.GetUpperBound(1))
	{
		for (int i = offsetTop; i <= array.GetUpperBound(0) - offsetBottom; i++)
		{
			count += 1;
			array[i, array.GetUpperBound(1) - offsetRight] = count;
			Console.Write($"offsetRight = {offsetRight},{count};");
		}
		offsetRight += 1;
	}

	if (offsetTop + offsetBottom <= array.GetUpperBound(0))
	{
		for (int i = array.GetUpperBound(1) - offsetRight; i >= offsetLeft; i--)
		{
			count += 1;
			Console.Write($"{offsetBottom},{i};");
			array[array.GetUpperBound(0) - offsetBottom, i] = count;
			Console.Write($"offsetBottom = {array.GetUpperBound(0) - offsetBottom},{i};");
		}
		offsetBottom += 1;
	}

	if (offsetLeft + offsetRight <= array.GetUpperBound(1))
	{
		for (int i = array.GetUpperBound(0) - offsetBottom; i >= offsetTop; i--)
		{
			count += 1;
			array[i, offsetLeft] = count;
			Console.Write($"offsetLeft = {i},{offsetLeft};");
		}
		offsetLeft += 1;
	}
}
PrintArray(array);