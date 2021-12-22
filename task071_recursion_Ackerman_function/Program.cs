// TODO Написать программу вычисления функции Аккермана
Console.Clear();
Console.WriteLine("Вычисление функции Аккермана A(m, n)");

Console.Write("Введите неотрицательное целое число M = "); 
int namberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное целое число N = "); 
int namberN = Convert.ToInt32(Console.ReadLine());


int AckermanFunction(int argM, int argN)
{
	if (argM < 1) return argN + 1;
	else if (argN <= 0 && argM > 0) 
		return AckermanFunction(argM - 1, 1);
	else if (argN > 0 && argM > 0) 
		return AckermanFunction(argM - 1, AckermanFunction(argM, argN - 1));
	else return 0;
}

Console.WriteLine($"A(m, n) = {AckermanFunction(namberM, namberN)}");