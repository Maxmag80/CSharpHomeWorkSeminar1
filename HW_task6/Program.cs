//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Pls, input integer number:");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 2 == 0)
    Console.WriteLine("Yes, this number is even");
else
    Console.WriteLine("No, this number is uneven");