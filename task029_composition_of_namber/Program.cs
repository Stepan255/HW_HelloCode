Console.Clear();
Console.WriteLine($"Написать программу вычисления произведения чисел от 1 до N (ноль исключается)");
Console.Write("Введите целое число N = "); 
double namberN = double.Parse(Console.ReadLine());

if (namberN * 10 % 10 == 0)
{
	if (namberN != 0)
	{
	double comp = 1;
	Console.Write("composition = 1");
	if (namberN != 1)
	{
		double sign = namberN / Math.Abs(namberN);
		for (double namber = 1 + sign; namber != namberN + sign;)
		{
			if (namber != 0)
			{
				Console.Write($" * {namber}");
				comp *= namber;
			}
			namber += sign;
		}
		Console.WriteLine();
		Console.WriteLine($"composition = {comp}");
	}
	}else Console.WriteLine("Вы ввели 0");

}else
Console.WriteLine("Вы ввели не целое число");