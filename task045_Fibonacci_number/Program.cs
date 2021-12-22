// todo Показать числа Фибоначчи
Console.Clear();
Console.WriteLine("Показать числа Фибоначчи");

double namberA = 0;
double namberB = 1;
int namberEnd = 10; // ! Количество чисел из ряда Фибоначчи

Console.Write($"{namberA}, {namberB}");
for (int i = 0; i < namberEnd; i++)
{
	namberA += namberB;
	namberB += namberA;
	Console.Write($", {namberA}, {namberB}");
}