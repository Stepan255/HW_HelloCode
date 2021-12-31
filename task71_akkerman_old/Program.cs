

int AckermanFunction(int argM, int argN)
{
	if (argM < 1)
	{
		return argN + 1;
	}
	else if (argN <= 0 && argM > 0)
	{
		return AckermanFunction(argM - 1, 1);
	}
	else if (argN > 0 && argM > 0)
	{
		int x = AckermanFunction(argM - 1, AckermanFunction(argM, argN - 1));
		Console.WriteLine(x);
		return x;
	}
	else return 0;
}

AckermanFunction(2, 5);