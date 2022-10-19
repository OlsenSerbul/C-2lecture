// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите число : ");
int number = Convert.ToInt32(Console.ReadLine());


if (number / 100 > 0 && number / 1000 < 0)
{
    Console.WriteLine(number= number % 100);

}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");

}
