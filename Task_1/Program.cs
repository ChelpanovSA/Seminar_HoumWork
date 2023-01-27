//Задача: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите число А ");
int numberA = int.Parse(Console.ReadLine()!);

Console.Write("Введите число B ");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA > numberB) 
{
    Console.WriteLine($"Большее число {numberA}");
    Console.WriteLine($"Меньшее число {numberB}");
}
if (numberA < numberB)
{
    Console.WriteLine($"Большее число {numberB}");
    Console.WriteLine($"Меньшее число {numberA}");
}
else if (numberA == numberB)
 {
    Console.WriteLine($"Числа равны {numberA} = {numberB}");
 }