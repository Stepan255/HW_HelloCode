// TODO Найти сумму элементов от M до N, N и M заданы
Console.Clear();
Console.WriteLine("Найти сумму элементов от M до N, N и M заданы");

int SumNamberFromMToN(int namberStart, int namberEnd, int sign)
{
	if (namberStart * sign >= namberEnd * sign)
	{
		Console.Write($"{namberStart}");
		return namberStart;
	}else
	{
		Console.Write($"{ + namberStart}, ");
		return namberStart + SumNamberFromMToN(namberStart + sign, namberEnd, sign);
	}
}

Console.Write("Введите M: ");
int namberM = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int namberN = int.Parse(Console.ReadLine());

int sign = (namberN - namberM) / Math.Abs(namberN - namberM);
int sum = SumNamberFromMToN(namberM, namberN, sign);
Console.WriteLine();
Console.WriteLine($"Сумма элементов от M до N равна {sum}");