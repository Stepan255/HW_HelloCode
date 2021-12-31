// TODO Написать программу вычисления функции Аккермана
Console.Clear();
Console.WriteLine("Вычисление функции Аккермана A(m, n)");





Console.Write("Введите неотрицательное целое число M = ");
double mNamber = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите неотрицательное целое число N = ");
double nNamber = Convert.ToDouble(Console.ReadLine());

DateTime saveTime = DateTime.Now;
// array1.Resize(ref array, )
double AddCountList(List<double[]> nList, double nListMaxCount, double count)
{
	while (nListMaxCount >= count)
	{
		double[] mArray = new double[mNamber];
		nList.Add(mArray);
		count++;
	}
}

List<double[]> nList = new List<double[]>();
double mArg = mNamber;
double nArg = nNamber;
double sum = 0;

while (nList[nNamber][mNamber] == 0)
{
	if (mArg < 1)
	{
		if (nList.Count() <= nArg) AddArrayToList(nList, nArg, nList.Count());
		if (nList[nArg][mArg] == 0) nList[nArg][mArg] = nArg + 1;
	}
	else if (nArg <= 0 && mArg > 0 && nList[nArg][mArg] != 0)
	{
		mArg -= 1;
		nArg = 1;
	}
	else if (argN > 0 && argM > 0)
	{
		if (nList.Count() <= nArg - 1) AddArrayToList(nList, nArg - 1, nList.Count());
		if (nList[nArg - 1][mArg] != 0)
		{
			if (nList.Count() <= nList[nArg - 1][mArg]) AddArrayToList(nList, nList[nArg - 1][mArg], nList.Count());
			if (nList[nList[nArg - 1][mArg]][mArg] != 0)
			{
				nArg = nList[nArg - 1][mArg];
			}else 
		}
	}
}


if (argM < 1)
{
	// Console.Write($"m={argM}, n={argN}; |");
	return array[argM, argN] = argN + 1;
}
else if (argN <= 0 && argM > 0)
{
	if (array[argM - 1, 1] == 0) return AckermanFunction(argM - 1, 1, array);
	else return array[argM - 1, 1];
}
else if (argN > 0 && argM > 0)
{
	if (array[argM, argN - 1] != 0)
		if (array[argM - 1, array[argM, argN - 1]] != 0) return array[argM - 1, array[argM, argN - 1]];
		else return AckermanFunction(argM - 1, array[argM, argN - 1], array);
	else return AckermanFunction(argM - 1, AckermanFunction(argM, argN - 1, array), array);
}
else return 0;

Console.WriteLine($"{DateTime.Now - saveTime}");

// Console.WriteLine($"A(m, n) = {AckermanFunction(namberM, namberN, array)}");