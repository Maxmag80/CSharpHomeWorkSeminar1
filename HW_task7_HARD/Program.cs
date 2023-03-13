//Задача 7 HARD по желанию - идет за 2 необязательных.
//Напишите программу, которая принимает на вход целое число любой разрядности и на выходе показывает
//вторую цифру слева этого числа или говорит, что такой цифры нет. Через строку решать нельзя.

Console.WriteLine("Pls, input any integer number: ");
int num = Convert.ToInt32(Console.ReadLine());
int secondNumber = 0;
num = Math.Abs(num);

if (num >= 10)
{
    while (num >= 10)
    {
        secondNumber = num % 10;
        num = num/10;
    }
    Console.WriteLine($"Second number is: {secondNumber}");
}
else
    Console.WriteLine("the number is single-digit, there is no second digit");