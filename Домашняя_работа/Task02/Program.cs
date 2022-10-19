// Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.

// запускаем генератор случайных чисел
Random rnd = new Random() ;
int number = rnd.Next();
Console.WriteLine(number);
int Number = number;

// запускаем цикл с проверкой есть ли в числе третья цифра

while (number / 100 > 0 )
{
    if (number < 1000 && number > 100)
    {
        number = number % 10;
        Console.WriteLine($"В числе {Number} третья цифра {number}" );
    }
    else
    {
        number = number / 10;
    }
 
}
 Console.WriteLine($"В числе {Number} третьей цифры нет" );



 number = number % 10;
     Console.WriteLine($"В числе {Number} третья цифра {number});

     if 