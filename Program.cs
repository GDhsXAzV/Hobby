using System;

Console.WriteLine("Имя:");
var name = Console.ReadLine();
Console.WriteLine("Фамилия:");
var surname = Console.ReadLine();
int age;
Console.WriteLine("Возраст:");
while (!int.TryParse(Console.ReadLine(), out age))
{
    Console.WriteLine("Ошибка, ввведите числом");
    Console.WriteLine();
    Console.WriteLine("Возраст:");
}

Console.WriteLine("Возраст:",age);
Console.WriteLine("Хобби:");
var hobby = Console.ReadLine();
Console.Write($" Результат: Имя:{name}, Фамилия: {surname},Возраст{age},Хобби:, {hobby}");

