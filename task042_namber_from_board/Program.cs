// todo Определить сколько чисел больше 0 введено с клавиатуры
Console.Clear();
Console.WriteLine("Определить сколько чисел больше 0 введено с клавиатуры");
Console.Write("Введите количество чисел которые хотите ввести: ");
int quantity = int.Parse(Console.ReadLine());

int count = 0;
double[] namberArray = new double[quantity];
for (int i = 0; i < quantity; i++)
{
	Console.Write($"Введите {i + 1} число: ");
	namberArray[i] = double.Parse(Console.ReadLine());
	if (namberArray[i] > 0) count += 1;
}
Console.WriteLine($"Количество чисел больше 0 равно {count}");