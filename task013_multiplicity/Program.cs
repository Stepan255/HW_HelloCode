Console.Clear();
Console.WriteLine($"Показывает кратно ли число заданному, если нет, то выводит остаток (N mod B = остаток).");
Console.Write("Введите число N = "); 
int namberN = int.Parse(Console.ReadLine());
Console.Write("Введите число B = "); 
int namberB = int.Parse(Console.ReadLine());

if (namberN % namberB == 0)
{
	Console.WriteLine($"Число {namberN} кратно {namberB}. {namberN} mod {namberB} = 0");
}else
{
	Console.WriteLine($"Остаток от деления равен {namberN % namberB} {namberN} mod {namberB} = {namberN % namberB}");
}