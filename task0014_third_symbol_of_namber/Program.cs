Console.Clear();
Console.WriteLine($"Находит третью цифру числа или сообщает, что её нет");
Console.Write("Введите число N = "); 
int namberN = int.Parse(Console.ReadLine());

if (namberN / 1000 != 0)
{
	Console.WriteLine($"Третий символ числа '{namberN}' равен: {(namberN % 1000)/100}");
}else
{
	Console.WriteLine($"В числе '{namberN}' меньше 3 разрядов");
}