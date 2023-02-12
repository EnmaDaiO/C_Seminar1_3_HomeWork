// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли 
// число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Введите число: ");
int firstNamber = Convert.ToInt32(Console.ReadLine());

if(firstNamber%2 == 0)
{
    Console.Write("Число " + firstNamber + " является четный");
}
else
{
    Console.Write("Число " + firstNamber + " не является четным");
}

