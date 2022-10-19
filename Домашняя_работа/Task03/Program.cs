// Напишите программу, которая принимает на вход цифру,  
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введите номер дня недели : ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1 || number> 7)
{
    Console.WriteLine("Такого номера дня недели нет. Введите число от 1 до 7");
}
if (number == 6 || number == 7)
{
    Console.WriteLine("Поздравляем! Сегодня выходной, отдыхаем!");
}
if (number > 0 && number < 6)
{
    Console.WriteLine("Сегодня не выходной! Работаем, товарищи!");
}