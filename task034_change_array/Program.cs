Console.Clear();
Console.WriteLine("Написать программу замену элементов массива на противоположные");
Console.Write("Введите длинну массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = new int[length];

Console.WriteLine("Исходный массив:");
for (int i = 0; i < length; i++)
{
	array[i] = new Random().Next(-9, 10);
	Console.WriteLine($"array[{i}] = {array[i]}");
}

Console.WriteLine("Полученный массив:");
for (int i = 0; i < length; i++)
{
	array[i] = -array[i];
	Console.WriteLine($"array[{i}] = {array[i]}");
}
