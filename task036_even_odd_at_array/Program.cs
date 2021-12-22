Console.Clear();
Console.WriteLine("Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных и четных чисел");
Console.Write("Введите длинну массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = new int[length];
int sum_even = 0;
int sum_odd = 0;
for (int i = 0; i < array.Length; i++)
{
	array[i] = new Random().Next(100, 1000);
		if (array[i] % 2 == 0) sum_even += 1;
		else sum_odd += 1;
	Console.Write($"{array[i]} ");
}

Console.WriteLine();
Console.WriteLine($"Количество четных чисел равно {sum_even}");
Console.WriteLine($"Количество нечетных чисел равно {sum_odd}");