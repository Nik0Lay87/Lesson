// Задача №17. Напишите программу, которая принимает на вход 
// координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в 
// которой находится эта точка.

Console.WriteLine("Введите координату точки по X");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату точки по Y");
int y = Conwert.ToInt32(Console.ReadLine());

if(x > 0 && y > 0)
{
    Console.WriteLine("Точка находтся в первой координатной четверти");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Точка находится во второй координатной четверти");
}
else if(x < 0 && y < 0)
{
    Console.WriteLine("Точка находится в третьей координатной четверти");
}
else if(x > 0 && y < 0)
{
    Console.WriteLine("Точка находится в четвёртой координатной четверти");
}
else 
{
    Console.WriteLine("Невозможно определить координатную четверть");
}