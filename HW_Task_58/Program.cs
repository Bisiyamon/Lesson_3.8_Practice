﻿//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

static int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void arrayFilling(int[,] arrayFillVoid)
{
    Random digit = new Random();
    for(int i = 0; i<arrayFillVoid.GetLength(0); i++)
    {
        for(int j = 0; j<arrayFillVoid.GetLength(1); j++)
        {
            arrayFillVoid[i, j] = digit.Next(0, 11);
        }
    }
}

static void arrayPrint(int[,] arrayPrintVoid)
{
    for(int i = 0; i<arrayPrintVoid.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j<arrayPrintVoid.GetLength(1); j++)
        {
            System.Console.Write("{0:d2} ", arrayPrintVoid[i,j]);
        }
    }
}

static void arraysMultiplication(int[,] arrayVoid1, int[,] arrayVoid2, int[,] arrayResultVoid)
{
    for(int iResult = 0, i=0; iResult < arrayResultVoid.GetLength(0); iResult++, i++)
    //for(int i = 0, j2 = 0, iResult = 0; i < arrayVoid1.GetLength(0) && j2 < arrayVoid2.GetLength(1) && iResult <arrayResult.GetLength(0); i++, j2++, iResult++)
    {
        for(int jResult = 0, j2 = 0; jResult < arrayResultVoid.GetLength(1); jResult++, j2++)
        {
            int cellMultiplicationResult = 0;
            for(int j = 0, i2 = 0; j < arrayVoid1.GetLength(1) && i2 < arrayVoid2.GetLength(0); j++, i2++)
            {
                cellMultiplicationResult += arrayVoid1[i,j] * arrayVoid2 [i2, j2];
            }
            arrayResultVoid[iResult, jResult] = cellMultiplicationResult;
        }

    }
}

int m = 2;
int n = 2;

int[,] array1 = new int[m, n];
int[,] array2 = new int [m,n];
int[,] arrayResult = new int[array1.GetLength(0), array2.GetLength(1)];

arrayFilling(array1);
arrayFilling(array2);
arrayPrint(array1);
System.Console.WriteLine();
arrayPrint(array2);
System.Console.WriteLine();
arraysMultiplication(array1, array2, arrayResult);
System.Console.WriteLine();

System.Console.WriteLine("Result of multiptication of 2 arrays: ");
arrayPrint(arrayResult);
System.Console.WriteLine();
System.Console.WriteLine();