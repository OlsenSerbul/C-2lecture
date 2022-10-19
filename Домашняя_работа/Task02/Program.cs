// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// запускаем генератор случайных чисел
Random rnd = new Random() ;
int number = rnd.Next();
Console.WriteLine(number);
//  проверяем есть ли в числе третья цифра
if (number >= 100)
// уменьшаем число до трехзначного
{
    while (number >= 1000)
    { 
        number = number / 10;
    }
 // находим остаток  от деления    
     number = number % 10;
     Console.WriteLine($"Третья цифра {number}");
}
else
{
   Console.WriteLine($"В числе нет третьей цифры");
    
}



