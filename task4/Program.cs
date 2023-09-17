// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Enter your number");
int number = Convert.ToInt32(Console.ReadLine());
int lastNumber = number % 10;

if (number >= 100 && number <= 999)
{
    lastNumber = number %10;
    Console.Write($"{number} -> {lastNumber}");
}
else
{
    Console.WriteLine("wrong number");
}
