// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// запускаем генератор случайных чисел
Random rnd = new Random() ;
int number = rnd.Next();
Console.WriteLine(number);

// запускаем цикл с проверкой есть ли в числе третья цифра
if (number >= 100)
{
    while (number % 100 > 0)
    {
        if (number < 1000)
        {
            number = number % 10;
            Console.WriteLine($"Третья цифра {number}");
        }
        else
    
            number = number / 10;
 
    }
}

else
{
   Console.WriteLine($"В числе нет третьей цифры");
    
}



