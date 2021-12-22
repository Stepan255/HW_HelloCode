// TODO Написать программу, которая обменивает элементы первой строки и последней строки
Console.Clear();
Console.WriteLine("Написать программу, которая обменивает элементы первой строки и последней строки");

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

for (int i = 0; i <= array.GetUpperBound(0); i++)
{
	int temporary = array[i, 0];
	array[i, 0] = array[i, array.GetUpperBound(1)];
	array[i, array.GetUpperBound(1)] = temporary;
}
Console.WriteLine();
PrintArray(array);