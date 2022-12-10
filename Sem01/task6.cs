// Задача 6: Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine();
string n = Console.ReadLine();
int n_n = int.Parse(n);
if (n_n % 2 == 0)
{
    Console.WriteLine("да");
}
else
{
    Console.WriteLine("нет");
}