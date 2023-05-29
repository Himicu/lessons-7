// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int InputNumber()
{
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void CraeteArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 100);
        }
    }
}
void ReversLine(int[,] mass)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        (mass[0, j], mass[mass.GetLength(0) - 1, j]) = (mass[mass.GetLength(0) - 1, j], mass[0, j]);
    }
}
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите число M: ");
int row = InputNumber();
Console.Write("Введите число N: ");
int colums = InputNumber();

int[,] array = new int[row, colums];
CraeteArray(array);
PrintArray(array);
Console.WriteLine();
ReversLine(array);
PrintArray(array);

