﻿// Имеется одномерный массив array из n элементов, требуется
// найти элемент массива, равный find
//  1. Установить счетчик index в позицию 0
//  2. Если array [index] = find, алгоритм завершил работу успешно.
//  3. Увеличить index на 1
//  4. Если index < n, то перейти к шагу 2. В противном случае
//    алгоритм завершил работу безуспешно.

void FillArray(int[] collection)

{
    int length = collection.Length;
    int index = 0;
    while(index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
       Console.WriteLine(col[position]);
       position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);

