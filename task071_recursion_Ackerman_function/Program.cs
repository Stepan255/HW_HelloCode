// TODO Написать программу вычисления функции Аккермана
Console.Clear();
Console.WriteLine("Вычисление функции Аккермана A(m, n)");

DateTime saveTime = DateTime.Now;
int AckermanFunction(int argM, int argN, int[,] array)
{
	if (argM < 1)
	{
		// Console.Write($"m={argM}, n={argN}; |");
		return array[argM, argN] = argN + 1;
	}else if (argN <= 0 && argM > 0)
	{
		if (array[argM - 1, 1] == 0) return AckermanFunction(argM - 1, 1, array);
		else return array[argM - 1, 1];
	}else if (argN > 0 && argM > 0)
	{
		if (array[argM, argN - 1] != 0)
			if(array[argM - 1, array[argM, argN - 1]] != 0) return array[argM - 1, array[argM, argN - 1]];
			else return AckermanFunction(argM - 1, array[argM, argN - 1], array);
		else return AckermanFunction(argM - 1, AckermanFunction(argM, argN - 1, array), array);
	}
	else return 0;
}



Console.WriteLine($"{DateTime.Now - saveTime}");

Console.Write("Введите неотрицательное целое число M = ");
int namberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите неотрицательное целое число N = ");
int namberN = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[namberM+ 1, 1000000];
Console.WriteLine($"A(m, n) = {AckermanFunction(namberM, namberN, array)}");