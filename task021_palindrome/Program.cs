Console.Clear();
Console.WriteLine("Программа проверяет пятизначное число на палиндромом.");
Console.Write("Введите пятизначное число N: "); 
int namberN = int.Parse(Console.ReadLine());

if ((namberN % 100000 >= 10000 || namberN % 100000 <= -10000) && namberN / 100000 == 0)
{
	if (namberN / 10000 == namberN % 10 && namberN / 1000 % 10 == namberN % 100 / 10)
	{
		Console.WriteLine($"Пятизначное число {namberN} - палиндром");
	}else
	{
		Console.WriteLine($"Пятизначное число {namberN} - НЕ палиндром");
	}
}else
{
	Console.WriteLine($"Вы ввели некоректное число: {namberN}");
}