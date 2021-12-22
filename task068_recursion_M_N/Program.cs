// TODO Показать натуральные числа от M до N, N и M заданы
Console.Clear();
Console.WriteLine("Показать натуральные числа от M до N, N и M заданы");

void ShoweNamberFromMToN(int namberStart, int namberEnd, int sign)
{
	if (namberStart * sign >= namberEnd * sign)
	{
		Console.Write($"{namberStart}");
	}else
	{
		Console.Write($"{namberStart}, ");
		ShoweNamberFromMToN(namberStart + sign, namberEnd, sign);
	}
}

Console.Write("Введите M: ");
int namberM = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int namberN = int.Parse(Console.ReadLine());

int sign = (namberN - namberM) / Math.Abs(namberN - namberM);
ShoweNamberFromMToN(namberM, namberN, sign);