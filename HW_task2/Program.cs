//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Pls, input first number:");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Pls, input second number:");
double num2 = Convert.ToDouble(Console.ReadLine());

if (num1 == num2)
    Console.WriteLine($"this numbers equal");
else
{
    if (num1 > num2)
        Console.WriteLine($"Max = {num1}; Min = {num2}");
    else
        Console.WriteLine($"Max = {num2}; Min = {num1}");
}