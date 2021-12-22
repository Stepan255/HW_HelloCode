// TODO Показать натуральные числа от 1 до N, N задано
Console.Clear();
Console.WriteLine("Показать натуральные числа от 1 до N, N задано");

void ShoweNamberFrom1ToN(int namberStart, int namberEnd)
{
	if (namberStart >= namberEnd)
	{
		Console.Write($"{namberStart}");
	}else
	{
		Console.Write($"{namberStart}, ");
		ShoweNamberFrom1ToN(namberStart + 1, namberEnd);
	}
}

Console.Write("Введите N: ");
int namberN = int.Parse(Console.ReadLine());

int start = 1;
ShoweNamberFrom1ToN(start, namberN);