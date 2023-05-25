// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

Console.WriteLine("Введите первую сторону треугольника А=");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую сторону треугольника В=");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью сторону треугольника С=");
int number3 = Convert.ToInt32(Console.ReadLine());

bool existTriangle = IsExistTriangle(number1, number2, number3);
Console.WriteLine(existTriangle ? "Существует" : "Не Существует");

bool IsExistTriangle(int a, int b, int c)
{
    return a + b > c && a + c > b && b + c > a;
}
