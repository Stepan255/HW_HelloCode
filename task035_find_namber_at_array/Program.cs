Console.Clear();
Console.WriteLine("Определить, присутствует ли в заданном массиве, некоторое число");
Console.Write("Введите длинну массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = new int[length];

for (int i = 0; i < array.Length; i++)
{
	array[i] = new Random().Next(-9, 10);
	Console.WriteLine($"array[{i}] = {array[i]}");
}

Console.Write("Введите число для поиска: ");
int find = int.Parse(Console.ReadLine());

bool check = true;
for (int i = 0; i < array.Length; i++)
{
	if (find == array[i]) 
	{
		Console.WriteLine($"Чило {find} находится в массиве под номером = {i}");
		check = false;
	}
}
if (check) Console.WriteLine($"В данном массиве нет числа {find}");