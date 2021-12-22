// TODO Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.
Console.Clear();
Console.WriteLine("Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.");

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
int lengthN = 0;
while (lengthN < 2)
{
	Console.Write("Введите n размерность массива (не меньше 2): n = ");
	lengthN = int.Parse(Console.ReadLine());
}

int[,] array = new int[lengthM, lengthN];
CreateArray(array, 0, 10);
PrintArray(array);
int indexMax = 0;
for (int k = 0; k <= array.GetUpperBound(1); k++)
{
	for (int i = 0; i <= array.GetUpperBound(0); i++)
	{
		indexMax = i;
		for (int j = i + 1; j <= array.GetUpperBound(0); j++)
			if (array[j, k] > array[indexMax, k]) indexMax = j;
		int temporary = array[i, k];
		array[i, k] = array[indexMax, k];
		array[indexMax, k] = temporary;
	}
}


PrintArray(array);