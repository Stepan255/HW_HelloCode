Console.Clear();
double stepOfRow = 0.3;
Console.WriteLine($"Показывает числа от -N до N(с шагом {stepOfRow})");
Console.Write("Введите значение N: "); 
double namberN = int.Parse(Console.ReadLine());

Console.WriteLine($"Числа от {-namberN} до {namberN} (с шагом {stepOfRow}):");
stepOfRow = stepOfRow * (namberN / Math.Abs(namberN));
for (double namberOfRow = -namberN; Math.Abs(namberOfRow) <= Math.Abs(namberN); namberOfRow = Math.Round(namberOfRow + stepOfRow, 1))
{
	Console.Write($"{namberOfRow}; ");
}
