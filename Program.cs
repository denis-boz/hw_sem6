/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

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