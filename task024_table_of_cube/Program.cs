Console.Clear();
Console.WriteLine($"Показать таблицу квадратов чисел от 1 до N ");
Console.Write("Введите натуральное число N = "); 
int namberN = int.Parse(Console.ReadLine());

Console.WriteLine("{0, 15}{1, 5}{2, 6}", "N", "|", "N^3");
for (double namber = 1; namber <= namberN; namber++)
{
	Console.WriteLine("{0,15}{1, 5}{2, 5}", namber, "|", namber * namber * namber);
}
Console.ReadLine();