Console.Clear();
Console.WriteLine($"Показать кубы чисел, заканчивающихся на четную цифру");
Console.Write("Введите натуральное число N = "); 
int namberN = int.Parse(Console.ReadLine());
Console.WriteLine("{0, 5}", "Кубы числ, заканчивающихся на четную цивру");
Console.WriteLine("{0, 5}{1, 5}{2, 6}", "N", "|", "N^3");
for (double namber = 2; namber <= namberN; namber += 2)
{
	Console.WriteLine("{0,5}{1, 5}{2, 5}", namber, "|", namber * namber * namber);
	Console.WriteLine("{0,5}{1, 5}{2, 5}", -namber, "|", -namber * namber * namber);
}