// Есть два массива info и data.
// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей.

// Массив info состоит из чисел, которые представляют колличество бит чисел из массива data.

// Составить массив десятичных представлений чисел массива data с учётом информации из массива info.

Console.Clear();

void FillArray(int[] array, int minValue, int maxValue)
{
	for (int i = 0; i < array.Length; i++)
	{
		array[i] = new Random().Next(minValue, maxValue);
	}

}

// int[] data = new int[10];
// FillArray(data, 0, 2);

// int[] info = new int[10];
// FillArray(info, 1, 10);

int[] data = {0, 1, 1, 1, 1, 0, 0, 0, 1 };

int[] info = {2, 3, 3, 1 };

List<int> namberList = new List<int>();
int index = 0;
for (int i = 0; i < info.Length; i++)
{
	int namber = 0;
	for (int j = 0; j < info[i]; j++)
	{
		namber += data[index] * Convert.ToInt32(Math.Pow(2, info[i] - j -1));
		index++;
	}
	namberList.Add(namber);
}

foreach (int namber in namberList)
{
	Console.Write($"{namber}, ");
}