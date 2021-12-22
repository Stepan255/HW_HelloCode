Console.Clear();
Console.WriteLine($"Найти сумму чисел одномерного массива стоящих на нечетной позиции (ноль четное))");
Console.Write("Введите длинну массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = new int[length];

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
	array[i] = new Random().Next(-1000, 1000);
		if (i % 2 != 0) 
		{
		sum += array[i];
		Console.WriteLine($"{i}. {array[i]}");
		}
}

Console.WriteLine($"Сумма чисел стоящих на нечетной позиции равна {sum}");