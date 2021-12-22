Console.Clear();
Console.WriteLine("Задать массив из 8 элементов и вывести их на экран ");

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
	Console.WriteLine($"array[{i}] = {array[i]}");
}