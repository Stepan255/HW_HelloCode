// TODO Написать программу масштабирования фигуры
Console.Clear();
Console.WriteLine("Написать программу масштабирования фигуры");

void PrintPointOfFigure(double[,] array)
{
	for (int i = 0; i <= array.GetUpperBound(1); i++)
		Console.Write($"({array[0, i]}; {array[1, i]}), ");
}

Console.Write("Введите коофициент масштабирования k = "); 
double namberK = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите количество углов фигуры n = "); 
int namberN = Convert.ToInt32(Console.ReadLine());

double[,] arrayOfPointFigure = new double[2, namberN];
for (int i = 0; i < namberN; i++)
{
	Console.Write($"Введите координату x точки {i + 1}: x{i + 1} = "); 
	arrayOfPointFigure[0, i] = Convert.ToDouble(Console.ReadLine());
	Console.Write($"Введите координату y точки {i + 1}: y{i + 1} = "); 
	arrayOfPointFigure[1, i] = Convert.ToDouble(Console.ReadLine());
}

Console.WriteLine("Изначальные точки фигуры");
PrintPointOfFigure(arrayOfPointFigure);

for (int i = 0; i < namberN; i++)
{
	arrayOfPointFigure[0, i] *= namberK;
	arrayOfPointFigure[1, i] *= namberK;
}

Console.WriteLine();
Console.WriteLine("Точки фигуры после масштабирования");
PrintPointOfFigure(arrayOfPointFigure);