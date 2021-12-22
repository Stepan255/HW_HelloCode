// TODO Проверить истинность утверждения !(X || Y) = (!X && !Y)

Console.Clear();
Console.WriteLine("Проверить истинность утверждения !(X || Y) = (!X && !Y)");
Console.WriteLine();

void CheckTrue(bool argX,bool argY)
{
	int meanArgX = 0;
	int meanArgY = 0;
	if (argX) meanArgX = 1;
	else
		meanArgX = 0;

	if (argY) meanArgY = 1;
	else
		meanArgY = 0;
	
	bool check = (!(argX || argY)) == (!argX && !argY);
	if (check)
	{
		// Старый вывод
		// Console.WriteLine($"утверждение (!X || Y) = (!X && !Y) - ИСТЕННО, при X = {meanArgX}, Y = {meanArgY}");
		Console.WriteLine($"{meanArgX, 5}{"|", 5}{meanArgY, 5}{"|", 5}{"1", 10}");
	}else
	{
		Console.WriteLine($"{meanArgX, 5}{"|", 5}{meanArgY, 5}{"|", 5}{"0", 10}");
	}
}

Console.WriteLine($"{"X", 5}{"|", 5}{"Y", 5}{"|", 5}{"!(X || Y) = (!X && !Y)", 5}");
Console.WriteLine();
CheckTrue(true, true);
CheckTrue(true, false);
CheckTrue(false, true);
CheckTrue(false, false);