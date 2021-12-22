// TODO В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
Console.Clear();
Console.WriteLine("В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.");

void CreateArray(int[,] createArray, int min, int max)
{
	for (int i = 0; i <= createArray.GetUpperBound(0); i++)
		for (int j = 0; j <= createArray.GetUpperBound(1); j++)
			createArray[i, j] = new Random().Next(min, max);
}

void PrintArray(int[,] printarray)
{
	Console.WriteLine();
	for (int i = 0; i <= printarray.GetUpperBound(0); i++)
	{
		for (int j = 0; j <= printarray.GetUpperBound(1); j++)
			Console.Write($"{"|", 5}{printarray[i, j], 5}");
		Console.WriteLine();
	}
}

Console.Write("Введите m размерность массива: m = ");
int lengthM = int.Parse(Console.ReadLine());
Console.Write("Введите n размерность массива: n = ");
int lengthN = int.Parse(Console.ReadLine());

int[,] array = new int[lengthM, lengthN];
CreateArray(array, 1, 10);
PrintArray(array);

int namberMin = array[0, 0];
int minM = 0;
int minN = 0;
for (int i = 0; i <= array.GetUpperBound(0); i++)
	for (int j = 0; j <= array.GetUpperBound(1); j++)
		if (array[i, j] < namberMin)
		{
			namberMin = array[i, j];
			minM = i;
			minN = j;
		}

// ! Зануляем строку и столбец
/* for (int i = 0; i <= array.GetUpperBound(0); i++)
{
	array[i, minN] = 0;
}

for (int i = 0; i <= array.GetUpperBound(1); i++)
{
	array[minM, i] = 0;
}
PrintArray(array); */

// ! Сдвиг вверх
for (int i = minM; i < array.GetUpperBound(0); i++)
	for (int j = 0; j <= array.GetUpperBound(1); j++)
		array[i, j] = array[i + 1, j];
// ! Сдвиг влево
for (int i = minN; i < array.GetUpperBound(1); i++)
	for (int j = 0; j <= array.GetUpperBound(0); j++)
		array[j, i] = array[j, i + 1];

int[,] newArray = new int[array.GetUpperBound(0), array.GetUpperBound(1)];
for (int i = 0; i < array.GetUpperBound(0); i++)
	for (int j = 0; j < array.GetUpperBound(1); j++)
		newArray[i, j] = array[i, j];

PrintArray(newArray);