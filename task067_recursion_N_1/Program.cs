// TODO Показать натуральные числа от N до 1, N задано
Console.Clear();
Console.WriteLine("Показать натуральные числа от N до 1, N задано");

void ShoweNamberFromNTo1(int namberStart, int namberEnd)
{
	if (namberStart <= namberEnd)
	{
		Console.Write($"{namberStart}");
	}else
	{
		Console.Write($"{namberStart}, ");
		ShoweNamberFromNTo1(namberStart - 1, namberEnd);
	}
}

Console.Write("Введите N: ");
int namberN = int.Parse(Console.ReadLine());

int end = 1;
ShoweNamberFromNTo1(namberN, end);