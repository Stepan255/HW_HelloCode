// TODO Написать программу, которая в двумерном массиве заменяет строки на столбцы
Console.Clear();
Console.WriteLine("Написать программу, которая в двумерном массиве заменяет строки на столбцы");

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

int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
for (int j = 0; j <= newArray.GetUpperBound(1); j++)
	for (int i = 0; i <= newArray.GetUpperBound(0); i++)
		newArray[i, j] = array[j, i];

PrintArray(newArray);