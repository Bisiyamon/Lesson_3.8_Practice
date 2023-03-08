//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы 
//каждой строки двумерного массива.

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

static void arrayArrangeHighLow(int[,] arrayArrangeHL)
{
    for(int i = 0; i<arrayArrangeHL.GetLength(0); i++)
    {
        for(int counter = 0; counter<arrayArrangeHL.GetLength(1); counter++)
        {
            for(int j = 0; j<arrayArrangeHL.GetLength(1)-1; j++)
            {
                if(arrayArrangeHL[i,j] < arrayArrangeHL[i,j+1])
                {
                    int digitTemporary = arrayArrangeHL[i,j+1];
                    arrayArrangeHL[i,j+1] = arrayArrangeHL[i,j];
                    arrayArrangeHL[i,j] = digitTemporary; 
                }
            }
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

int m = Prompt("Input amount of array rows? - ");
int n = Prompt("Input amount of array columns? - ");

int[,] array = new int[m, n];
arrayFilling(array);
arrayPrint(array);
System.Console.WriteLine();
arrayArrangeHighLow(array);
arrayPrint(array);
System.Console.WriteLine();