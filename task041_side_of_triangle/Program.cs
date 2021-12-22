// todo Выяснить являются ли три числа сторонами треугольника 
Console.Clear();
Console.WriteLine("Выяснить являются ли три числа сторонами треугольника ");
Console.Write("Введите первое число: ");
double namberA = double.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
double namberB = double.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
double namberC = double.Parse(Console.ReadLine());

if (namberA + namberB > namberC && namberB + namberC > namberA && namberA + namberC > namberB) 
	Console.WriteLine($"Три числа {namberA}, {namberB} и {namberC} являются сторонами треугольника ");
else 
	Console.WriteLine($"Три числа {namberA}, {namberB} и {namberC} НЕ являются сторонами треугольника ");