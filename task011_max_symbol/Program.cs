Console.Clear();
Console.WriteLine("Показывает наибольшую цифру числа из отрезка [10, 99]");

int namberRand = new Random().Next(10, 100); // [10 ; 99]

if (namberRand % 10 > namberRand / 10)
{
	Console.Write($"Наибольшая цифра числа {namberRand} равна {namberRand % 10}"); 
}else
{
	Console.Write($"Наибольшая цифра числа {namberRand} равна {namberRand / 10}");
}