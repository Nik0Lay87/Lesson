// Задача 9. Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int number = Random.Shared.Next(10, 100);
Console.WriteLine(number);
int lastDigit = number % 10;
int firstDigit = number / 10;
if(firstDigit > lastDigit)
{
    //Console.WriteLine(firstDigit);
    Console.WriteLine($"max {firstDigit}, min {lastDigit}");
}
else
{
    //Console.WriteLine(lastDigit);
    Console.WriteLine($"max {lastDigit}, min {firstDigit}");
}