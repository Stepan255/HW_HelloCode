// todo Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.
Console.Clear();
Console.WriteLine("Найти произведение пар чисел в одномерном массиве.");
Console.Write("Введите длинну массива: ");
int length = int.Parse(Console.ReadLine());

double[] array = new double[length];
for (int i = 0; i < array.Length; i++)
{
	array[i] = new Random().Next(0, 100);
	Console.WriteLine($"array [{i}] =  {array[i]}");
}

for (int i = 0; i < array.Length / 2; i++)
{
	Console.WriteLine($"Произведение пары №{i + 1} равно {array[i] * array[array.GetUpperBound(0) - i]}");
}

if (array.Length % 2 != 0) Console.WriteLine($"Произведение центрального числа (без пары) само на себя равно {array[array.Length / 2] * array[array.Length / 2]}");