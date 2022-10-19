// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число : ");
int number = Convert.ToInt32(Console.ReadLine());


if (number >= 100  && number < 1000)
{
    number = number / 10;
    Console.WriteLine(number = number % 10);

}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");

}
