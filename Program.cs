﻿// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
int[,,] num = new int[2, 2, 2];
int ran = 10;
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        for (int k = 0; k < num.GetLength(2); k++)
        {
            ran += 6;
            num[i, j, k] = ran;
            Console.Write($" {num[i, j, k]}");
        }
        Console.WriteLine();
    }
}
Console.WriteLine();
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int j = 0; j < num.GetLength(1); j++)
    {
        for (int k = 0; k < num.GetLength(2); k++)
        {
            Console.Write($" {num[i, j, k]} ({i},{j},{k})");
        }
        Console.WriteLine();
    }
}