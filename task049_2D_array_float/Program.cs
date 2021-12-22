// todo Показать двумерный массив размером m×n заполненный вещественными числами (49)
Console.Clear();
Console.WriteLine("Показать двумерный массив размером m*n заполненный вещественными числами");

void CreateArray(double[,] createArray,int minElementValue,int maxElementValue)
{
	for (int i = 0; i < createArray.GetLength(0); i++)
	{
		for (int j = 0; j < createArray.GetLength(1); j++)
		{
			createArray[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(minElementValue, maxElementValue), 2);
		}
	}
}

void PrintArray(double[,] printArray)
{
	for (int i = 0; i < printArray.GetLength(0); i++)
	{
		Console.Write("{0, 10}", printArray[i, 0]);
		for (int j = 1; j < printArray.GetLength(1); j++)
		{
			Console.Write($"{"|", 10} {printArray[i, j], 10}");
		}
		Console.WriteLine();
	}
}

Console.Write("Введите m координату массива: m = ");
int lengthM = int.Parse(Console.ReadLine());
Console.Write("Введите n координату массива: n = ");
int lengthN = int.Parse(Console.ReadLine());
double[,] array = new double[lengthM, lengthN];
CreateArray(array, -15, 15);
PrintArray(array);