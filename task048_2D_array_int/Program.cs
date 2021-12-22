// todo Показать двумерный массив размером m×n заполненный целыми числами
Console.Clear();
Console.WriteLine("Показать двумерный массив размером m×n заполненный целыми числами");

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

Console.Write("Введите m координату массива: m = ");
int lengthM = int.Parse(Console.ReadLine());
Console.Write("Введите n координату массива: n = ");
int lengthN = int.Parse(Console.ReadLine());
int[,] array = new int[lengthN, lengthM];
CreateArray(array, -15, 15);
PrintArray(array);