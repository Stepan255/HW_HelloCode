// TODO Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем
Console.Clear();
Console.WriteLine("Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. Первые два элемента последовательности задаются пользователем");

void ShoweSequence(double firstNamber, double secondNamber, int length)
{
	if (length <= 1) Console.Write($", {firstNamber + secondNamber}");
	else
	{
		Console.Write($", {firstNamber + secondNamber}");
		ShoweSequence(secondNamber, firstNamber + secondNamber, length - 1);
	}
}

Console.Write("Введите неотрицательное целое число A = "); 
double namberA = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите неотрицательное целое число B = "); 
double namberB = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите неотрицательное целое число N = "); 
int namberN = Convert.ToInt32(Console.ReadLine());

Console.Write($"{namberA}, {namberB}");
ShoweSequence(namberA, namberB, namberN);