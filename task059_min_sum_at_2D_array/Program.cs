// TODO В прямоугольной матрице найти строку с наименьшей суммой элементов.
Console.Clear();
Console.WriteLine("В прямоугольной матрице найти строку с наименьшей суммой элементов.");

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

int sumMin = 0;
for (int i = 0; i <= array.GetUpperBound(0); i++)
	sumMin += array[i, 0];

int indexMin = 0;
for (int j = 1; j <= array.GetUpperBound(1); j++)
{
	int sum = 0;
	for (int i = 0; i <= array.GetUpperBound(0); i++)
		sum += array[i, j];
	// Проверка работоспособности
	//Console.WriteLine($"Сумма элементов {j} строки - {sum}");
	if (sum < sumMin) 
	{
		sumMin = sum;
		indexMin = j;
	}
}

Console.WriteLine($"Строка с наименьшей суммой элементов - {indexMin + 1}");
