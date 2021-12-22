// TODO Найти произведение двух матриц
Console.Clear();
Console.WriteLine("Найти произведение двух матриц");

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

Console.Write("Введите количество столбцов матрицы X (это будет количество строк матрицы Y): m = ");
int lengthM = int.Parse(Console.ReadLine());
Console.Write("Введите количество строк матрицы X: n = ");
int lengthN = int.Parse(Console.ReadLine());
Console.Write("Введите количество столбцов матрицы Y: l = ");
int lengthL = int.Parse(Console.ReadLine());


int[,] arrayX = new int[lengthN, lengthM];
int[,] arrayY = new int[lengthM, lengthL];
CreateArray(arrayX, 100, 1000);
CreateArray(arrayY, 100, 1000);
if ((arrayX.GetUpperBound(0) + 1) * (arrayX.GetUpperBound(0) + 1) <= 100) PrintArray(arrayX);
if ((arrayY.GetUpperBound(0) + 1) * (arrayY.GetUpperBound(0) + 1) <= 100) PrintArray(arrayY);

int[,] compositionArray = new int[arrayX.GetUpperBound(0) + 1, arrayY.GetUpperBound(1) + 1];

for (int i = 0; i <= compositionArray.GetUpperBound(0); i++)
	for (int j = 0; j <= compositionArray.GetUpperBound(1); j++)
		for (int k = 0; k <= arrayX.GetUpperBound(1); k++)
			compositionArray[i, j] += arrayX[i, k] * arrayY[k, j];
Console.WriteLine();
PrintArray(compositionArray);