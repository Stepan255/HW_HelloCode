// TODO Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента
Console.Clear();
Console.WriteLine("Сформировать трехмерный массив () не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента");

bool check = false;
int lengthM = 0;
int lengthN = 0;
int lengthZ = 0;
do{
	if (check) Console.WriteLine($"Невозможно создать такой массив, т. к. должно выполняться условие: m * n * z <= 90");
	Console.Write("Введите m размерность массива: m = ");
	lengthM = int.Parse(Console.ReadLine());
	Console.Write("Введите n размерность массива: n = ");
	lengthN = int.Parse(Console.ReadLine());
	Console.Write("Введите n размерность массива: z = ");
	lengthZ = int.Parse(Console.ReadLine());
	check = true;
}while (lengthM * lengthN * lengthZ > 90);

int lengthNamberArray = 90;
int[] namberArray = new int[lengthNamberArray];

int[,,] array = new int[lengthM, lengthN, lengthZ];

int namberOfNamber = 0;
for (int i = 0; i <= array.GetUpperBound(0); i++)
	for (int j = 0; j <= array.GetUpperBound(1); j++)
		for (int k = 0; k <= array.GetUpperBound(2); k++)
		{
			check = true;
			while (check)
			{
				array[i, j, k] = new Random().Next(10, 100);
				check = false;
				for (int t = 0; t < namberOfNamber; t++)
				{
					if (array[i, j, k] == namberArray[t]) 
					{
						check = true;
						break;
					}
				}
			}
			namberArray[namberOfNamber] = array[i, j, k];
			namberOfNamber += 1;
			Console.Write($"{array[i, j, k]}[{i}, {j}, {k}]; ");
		}

// ! Проверка правильности алгоритма
/*
Console.WriteLine();
Console.WriteLine(namberOfNamber);
int indexMax =0;
for (int i = 0; i <= namberArray.GetUpperBound(0); i++)
	{
		indexMax = i;
		for (int j = i + 1; j <= namberArray.GetUpperBound(0); j++)
			if (namberArray[j] > namberArray[indexMax]) indexMax = j;
		int temporary = namberArray[i];
		namberArray[i] = namberArray[indexMax];
		namberArray[indexMax] = temporary;
	}
for (int i = 0; i < namberArray.Length; i++)
{
	Console.Write($"{namberArray[i]}; ");
}
*/