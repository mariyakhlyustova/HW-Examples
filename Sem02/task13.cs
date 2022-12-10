// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine();
string num1=Console.ReadLine()!;


if (num1.Length<3 || (num1.Length==3 && num1[0]=='-')) Console.WriteLine("третьей цифры нет");

if (num1[0]=='-') Console.WriteLine(num1[3]);
else Console.WriteLine(num1[2]);
