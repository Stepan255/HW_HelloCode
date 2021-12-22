// todo В двумерном массиве n×k заменить четные элементы на противоположные
Console.Clear();
Console.WriteLine("В двумерном массиве n×k заменить четные элементы на противоположные");

void CreateArray(int[,] createArray,int min,int max)
{
	for (int i = 0; i <= createArray.GetUpperBound(0); i++)
	{
		for (int j = 0; j <= createArray.GetUpperBound(1); j++)
		{
			createArray[i, j] = new Random().Next(min, max);
		}
	}
}

void PrintArray(int[,] printArray)
{
	for (int i = 0; i <= printArray.GetUpperBound(0); i++)
	{
		Console.Write("{0, 5}", printArray[i, 0]);
		for (int j = 1; j <= printArray.GetUpperBound(1); j++)
		{
			Console.Write($"{"|", 5} {printArray[i, j], 5}");
		}
		Console.WriteLine();
	}
}

Console.Write("Введите m координату массива: n = ");
int lengthN = int.Parse(Console.ReadLine());
Console.Write("Введите n координату массива: k = ");
int lengthK = int.Parse(Console.ReadLine());
int[,] array = new int[lengthK, lengthN];
CreateArray(array, 0, 15);
PrintArray(array);

Console.WriteLine();

for (int i = 0; i <= array.GetUpperBound(0); i++)
{
	for (int j = 0; j <= array.GetUpperBound(1); j++)
	{
		if (array[i, j] % 2 == 0) array[i, j] *= -1;
	}
}

PrintArray(array);