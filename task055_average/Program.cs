// TODO Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
Console.Clear();
Console.WriteLine("Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.");

void CreateArray(int[,] createArray, int min, int max)
{
	for (int j = 0; j <= createArray.GetUpperBound(1); j++)
		for (int i = 0; i <= createArray.GetUpperBound(0); i++)
			createArray[i, j] = new Random().Next(min, max);
}

void PrintArray(int[,] printarray)
{
	Console.WriteLine();
	for (int j = 0; j <= printarray.GetUpperBound(1); j++)
	{
		for (int i = 0; i <= printarray.GetUpperBound(0); i++)
			Console.Write($"{"|", 5}{printarray[i, j], 5}");
		Console.WriteLine();
	}
}

Console.Write("Введите m размерность массива: m = ");
int lengthM = int.Parse(Console.ReadLine());
Console.Write("Введите n размерность массива: n = ");
int lengthN = int.Parse(Console.ReadLine());
int[,] array = new int[lengthM, lengthN];
CreateArray(array, 0, 10);
PrintArray(array);

double[] average = new double[array.GetUpperBound(0) + 1];
for (int i = 0; i <= array.GetUpperBound(0); i++)
{
	double sum = 0;
	for (int j = 0; j <= array.GetUpperBound(1); j++)
		sum += array[i, j];
	average[i] = sum / (array.GetUpperBound(1) + 1);
}

for (int i = 0; i <= average.GetUpperBound(0); i++)
	Console.Write($"{"|", 5}{average[i], 5}");
