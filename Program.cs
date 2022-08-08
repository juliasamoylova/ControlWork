// Написать программу, которая из имеющегося массива строк, формирует массив из строк, длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.

string[] array = new string[8];
Console.Write("Задайте первый элемент массива:");
string element1 = Console.ReadLine();
Console.Write("Задайте второй элемент массива:");
string element2 = Console.ReadLine();
Console.Write("Задайте третий элемент массива:");
string element3 = Console.ReadLine();
Console.Write("Задайте четвертый элемент массива:");
string element4 = Console.ReadLine();
Console.Write("Задайте пятый элемент массива:");
string element5 = Console.ReadLine();
Console.Write("Задайте шестой элемент массива:");
string element6 = Console.ReadLine();
Console.Write("Задайте седьмой элемент массива:");
string element7 = Console.ReadLine();
Console.Write("Задайте восьмой элемент массива:");
string element8 = Console.ReadLine();

for (int i = 0; i < 8; i++)
{
    array[i] = new Random().Next(1000);
    Console.Write(array[i] + ";");
