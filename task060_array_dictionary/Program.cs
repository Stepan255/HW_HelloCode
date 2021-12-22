// TODO Составить частотный словарь элементов двумерного массива
// ! Есть минус - не видит слова равные "0"
// ! в массиве arrayDictinary в 0 элементе столбца лежит слово, а в 1 колличество
Console.Clear();
Console.WriteLine("Составить частотный словарь элементов двумерного массива");

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
CreateArray(array, 100, 1000);
if ((array.GetUpperBound(0) + 1) * (array.GetUpperBound(0) + 1) <= 400) PrintArray(array);

int[,] arrayDictinary = new int[(array.GetUpperBound(0) + 1) * (array.GetUpperBound(1) + 1), 2];
int namberOfWords = 0;
int wordAdd = 0;
for (int j = 0; j <= array.GetUpperBound(1); j++)
	for (int i = 0; i <= array.GetUpperBound(0); i++)
	{
		bool check = true;
		for (int k = 0; k <= arrayDictinary.GetUpperBound(0); k++)
		{
			if (arrayDictinary[k, 0] == 0) break;
			if (array[i, j] == arrayDictinary[k, 0])
			{
				wordAdd = k;
				check = false;
				break;
			}
		}
		if (check)
		{
			arrayDictinary[namberOfWords, 0] = array[i, j];
			arrayDictinary[namberOfWords, 1] += 1;
			namberOfWords += 1;
		}else arrayDictinary[wordAdd, 1] += 1;
	}
for (int j = 0; j < arrayDictinary.GetUpperBound(0); j++)
	if (arrayDictinary[j, 0] != 0) Console.WriteLine($"{j+1}. {arrayDictinary[j, 1]} слов {arrayDictinary[j, 0]} в этом массиве");
	else
		break;
Console.WriteLine($"Всего слов в массиве: {namberOfWords}");
