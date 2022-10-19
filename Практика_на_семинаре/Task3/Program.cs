// Напишите программу, которая будет принимать на вход два числа 
// и выводить, является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
Console.WriteLine("Введите число А: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
int X =numberA % numberB;
while(numberA > numberB)
{

    if (X > 0) Console.WriteLine($"не кратно, остаток {X} ");
else
Console.WriteLine("кратно");

}

Console.WriteLine("Первое число меньше второго, целочисленного остатка нет");