// TODO Показать треугольник Паскаля
Console.Clear();
// ! То что было на лекции
/*
int x1 = 105;
int y1 = 2;
Console.SetCursorPosition(x1, y1);
Console.Write("+");

int x2 = 5;
int y2 = 50;
Console.SetCursorPosition(x2, y2);
Console.Write("+");

int x3 = 205;
int y3 = 50;
Console.SetCursorPosition(x3, y3);
Console.Write("+");

int x = x1;
int y = y1;
int length = 20000;
for (int i = 0; i <= length; i++)
{
	int random = new Random().Next(1, 4);
	if (random == 1)
	{
		x = (x + x1) / 2;
		y = (y + y1) / 2;
	}

	if (random == 2)
	{
		x = (x + x2) / 2;
		y = (y + y2) / 2;
	}

	if (random == 3)
	{
		x = (x + x3) / 2;
		y = (y + y3) / 2;
	}

	Console.SetCursorPosition(x, y);
	Console.Write("+");
}
Console.SetCursorPosition(1, 51);
*/
Console.Write("Введите количество строк для треугольника Паскаля: m = ");
int namberOfLines = int.Parse(Console.ReadLine());

double[,] arrayPascalTriangle = new double[namberOfLines + 1, namberOfLines * 2 + 3];

arrayPascalTriangle[0, namberOfLines + 1] = 1;

for (int i = 1; i <= namberOfLines; i++)
	for (int j = 1; j <= arrayPascalTriangle.GetUpperBound(1) - 1; j++)
		arrayPascalTriangle[i, j] = arrayPascalTriangle[i - 1, j - 1] + arrayPascalTriangle[i - 1, j + 1];

for (int i = 0; i <= arrayPascalTriangle.GetUpperBound(0); i++)
{
	for (int j = 0; j <= arrayPascalTriangle.GetUpperBound(1); j++)
	{
		if (arrayPascalTriangle[i,j] == 0) Console.Write($"{"", 1}");
		else
			Console.Write($"{arrayPascalTriangle[i,j]}");
	}
Console.WriteLine();
}