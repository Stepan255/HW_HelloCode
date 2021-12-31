// TODO Найти сумму элементов от M до N, N и M заданы
Console.Clear();
Console.WriteLine("Найти сумму элементов от M до N, N и M заданы");

int SumNamberFromMToN(int namberStart, int namberEnd)
{
	if (namberStart >= namberEnd)
	{
		return namberStart;
	}else
	{
		// Console.Write($"{ + namberStart}, ");
		return namberStart + SumNamberFromMToN(namberStart + 1, namberEnd);
	}
}

Console.Write("Введите M: ");
int namberM = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int namberN = int.Parse(Console.ReadLine());

int sum = 0;
if (namberM > namberN) sum = SumNamberFromMToN(namberN, namberM);
else 
	sum = SumNamberFromMToN(namberM, namberN);

Console.WriteLine($"Сумма элементов от M до N равна {sum}");