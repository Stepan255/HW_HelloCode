// TODO В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
Console.Clear();
Console.WriteLine("В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет");

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

Console.Write("Введите число для поиска: ");
int find = int.Parse(Console.ReadLine());

bool check = true;
for (int j = 0; j <= array.GetUpperBound(1); j++)
	for (int i = 0; i <= array.GetUpperBound(0); i++)
		if (find == array[i, j]) 
		{
		if (check) Console.WriteLine($"Число {find} находится в массиве под номером = [{i}, {j}]");
		else
			Console.WriteLine($"Так же число {find} находится в массиве под номером = [{i}, {j}]");
		check = false;
		}
if (check) Console.WriteLine($"В данном массиве нет числа {find}");