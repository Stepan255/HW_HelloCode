// ! По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();
Console.WriteLine("Задается два числа. По заданным числам проверять является ли одно квадратом другого");
Console.Write("Введите значение A: "); 
int namberA = int.Parse(Console.ReadLine());
Console.Write("Введите значение B: "); 
int namberB = int.Parse(Console.ReadLine());
if (namberB == namberA * namberA) Console.WriteLine($"{namberB} = {namberA} * {namberA}");
else 
	if (namberA == namberB * namberB) Console.WriteLine($"{namberA} = {namberB} * {namberB}");
else
	Console.WriteLine("Ни одно из введенных чисел не является квадратом другого!");
