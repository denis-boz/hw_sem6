/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

/*
int[] GetArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: ");
        newArray[i] = int.Parse(Console.ReadLine());
    }
    return newArray;
}
int[] resultArray = GetArray(5);
Console.WriteLine($"Введенный массив: [{String.Join(", ", resultArray)}]");

int result = 0;
for (int i = 0; i < resultArray.Length; i++)
{
    if (resultArray[i] > 0)
    {
        result ++;
    }
}
Console.WriteLine($"Чисел больше нуля: {result}");
*/

/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

Console.Write("Введите значение b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Точка пересечения двух прямых равна: {Math.Round((b2 - b1) / (k1 - k2), 2)}, {Math.Round((k1 * (b2 - b1) / (k1 - k2) + b1), 2)}");