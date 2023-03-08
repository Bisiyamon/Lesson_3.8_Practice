// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

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
            System.Console.Write(arrayPrintVoid[i,j] + "    ");
        }
    }
}

static void arrayFillingSumOfRow(int[,] arraySMSVoid, int[] arrayOfSumVoid)
{
    //int[] arrayOfSum = new int[arraySMSVoid.GetLength(0)];
    int index = 0;
    for(int i = 0; i < arraySMSVoid.GetLength(0); i++)
    {
        int rowSum = 0;
        for (int j = 0; j < arraySMSVoid.GetLength(1); j++)
        {
            rowSum = rowSum + arraySMSVoid[i, j];
        }
        arrayOfSumVoid[index] = rowSum;
        index++;
    }
}

static void arraySearchMinimalSum(int[] arrayOfSumVoid)
{
    int imin = 0;
    int minimalValue = arrayOfSumVoid[imin];
    for (int i = 0; i<arrayOfSumVoid.Length; i++)
    {
        if(arrayOfSumVoid[i] < minimalValue)
        {
            minimalValue = arrayOfSumVoid[i];
            imin = i;
        }
    }
    System.Console.WriteLine($"Minimal Sum of numbers in {imin+1} row and it amount {minimalValue}");
}

int m = 5;
int n = 6;

int[,] array = new int[m, n];
int[] arrayOfSum = new int[array.GetLength(0)];
arrayFilling(array);
arrayPrint(array);
System.Console.WriteLine();
arrayFillingSumOfRow(array, arrayOfSum);
System.Console.WriteLine();

System.Console.Write("Sun of each row: ");
foreach(int value in arrayOfSum)
{
    System.Console.Write($"{value}  ");
}
System.Console.WriteLine();
arraySearchMinimalSum(arrayOfSum);
System.Console.WriteLine();