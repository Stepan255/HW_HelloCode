// TODO В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.Clear();
Console.WriteLine("В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты");

void CreateArray(int[,] createArray, int min, int max)
{
	for (int i = 0; i <= createArray.GetUpperBound(0); i++)
		for (int j = 0; j < createArray.GetUpperBound(1); j++)
		{
			createArray[i, j] = new Random().Next(min, max);
			if (i % 2 == 0 && j % 2 == 0) createArray[i, j] *= createArray[i, j];
		}
}

void PrintArray(int[,] printarray)
{
	for (int i = 0; i <= printarray.GetUpperBound(0); i++)
	{
		for (int j = 0; j < printarray.GetUpperBound(1); j++)
			Console.Write($"{"|", 5}{printarray[i, j], 5}");
		Console.WriteLine();
	}
}

Console.Write("Введите m координату массива: m = ");
int lengthM = int.Parse(Console.ReadLine());
Console.Write("Введите n координату массива: n = ");
int lengthN = int.Parse(Console.ReadLine());
int[,] array = new int[lengthN, lengthM];
CreateArray(array, -20, 0);
PrintArray(array);