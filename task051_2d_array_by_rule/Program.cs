// todo Задать двумерный массив следующим правилом: Aₘₙ = m+n
Console.Clear();
Console.WriteLine("Задать двумерный массив следующим правилом: Aₘₙ = m+n");

void CreateArray(int[,] createArray)
{
	for (int i = 0; i <= createArray.GetUpperBound(0); i++)
	{
		for (int j = 0; j <= createArray.GetUpperBound(1); j++)
		{
			createArray[i, j] = i + j;
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
CreateArray(array);
PrintArray(array);