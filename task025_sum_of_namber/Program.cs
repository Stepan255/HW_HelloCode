
Console.Clear();
Console.WriteLine($"Найти сумму целых чисел от 1 до А");
Console.Write("Введите целое число A = "); 
double namberA = double.Parse(Console.ReadLine());

DateTime saveTime = DateTime.Now;
Console.WriteLine((namberA + 1) * namberA / 2);
Console.WriteLine($"{DateTime.Now - saveTime}");
// Console.WriteLine($"{DateTime.Now - saveTime}");
// if (namberA * 10 % 10 == 0)
// {
// 	double sum = 1;
// 	Console.Write("sum = 1");
// 	if (namberA != 0 || namberA != 1)
// 	{
// 		double sign = namberA / Math.Abs(namberA);
// 		for (double namber = 1 + sign; namber != namberA + sign;)
// 		{
// 			Console.Write($" + {namber}");
// 			sum += namber;
// 			namber += sign;
// 		}
// 		Console.WriteLine();
// 		Console.WriteLine($"sum = {sum}");
// 	}
// }else
// {
// 	Console.WriteLine("Вы ввели не целое число");
// }
// Console.WriteLine($"{DateTime.Now - saveTime}");