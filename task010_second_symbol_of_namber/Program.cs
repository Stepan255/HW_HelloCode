﻿// TODO Показать вторую цифру трёхзначного числа
Console.Clear();
Console.WriteLine($"Показать вторую цифру трёхзначного числа");
Console.Write("Введите трехзначное целое число N = "); 
int namberN = int.Parse(Console.ReadLine());

if ((namberN % 1000 >= 100 || namberN % 1000 <= -100) && namberN / 1000 == 0)
	Console.WriteLine($"Второй символ числа {namberN} равен: {(namberN % 100) / 10}");
else
	Console.WriteLine($"Вы ввели некоректное число: {namberN}");