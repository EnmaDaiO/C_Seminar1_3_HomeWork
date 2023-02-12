// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное
//  из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Введите первое число: ");
int firstNamber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int secondNamber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int thirdNamber = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (firstNamber > max) max = firstNamber;
if (secondNamber > max) max = secondNamber;
if (thirdNamber > max) max = thirdNamber;
Console.Write("Максимальное число из заданных = ");
Console.WriteLine(max);