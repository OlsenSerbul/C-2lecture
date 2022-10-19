// Напишите программу, которая выводит случайное трёхзначное число 
// и удаляет вторую цифру этого числа.
int number = new Random().Next(100, 1000);
int a = number % 10;
int b = number / 10;
int c = number / 100;
Console.WriteLine($"Число: {number} ");

Console.WriteLine($"Новое число: {c}{a}");


