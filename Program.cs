//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

//b1 = 2, k1 = 5, b2 = 4, k2 = 9-> (-0, 5; -0,5)

using static System.Console;

Write("Enter coordinate b1= ");
double b1 = int.Parse(ReadLine());
Write("Enter coordinate k1= ");
double k1 = int.Parse(ReadLine());
Write("Enter coordinate b2= ");
double b2 = int.Parse(ReadLine());
Write("Enter coordinate k2= ");
double k2 = int.Parse(ReadLine());



if (k1 == k2)
{
    if (b1 == b2) WriteLine("Straight lines are matched");
    else WriteLine("Lines are parallel");
}
else WriteLine($"The Point of intersection is at the point({x(b1, k1, b2, k2)};{y(b1, k1, x(b1, k1, b2, k2))})");



double x(double b1, double k1, double b2, double k2)
{
    return (b2 - b1) / (k1 - k2);
}
double y(double b, double k, double x)
{
    return k * x + b;
}