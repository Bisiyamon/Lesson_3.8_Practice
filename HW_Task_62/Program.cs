/* Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

static int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void arraySpiralFilling(int[,] arraySpiralVoid)
{
    int iStart = 0;
    int iFinish = arraySpiralVoid.GetLength(0);
    int jStart = 0;
    int jFinish = arraySpiralVoid.GetLength(1);
    int iCurrent = iStart;
    int jCurrent = jStart;
    int count = 0;
    
    for(int index = 0; index < arraySpiralVoid.GetLength(0)+arraySpiralVoid.GetLength(1)-1; index++)
    {
        if(iCurrent == iStart && jCurrent == jStart)
        {
            for (int j = jCurrent, i = iCurrent; j < jFinish; j++)
            {
                arraySpiralVoid[i,j] = count;
                count++;
            }
            iStart = iStart+1;
            iCurrent = iStart;
            jCurrent = jFinish;
        }

        if(iCurrent == iStart && jCurrent == jFinish)
        {
            for(int i = iCurrent, j = jCurrent-1; i < iFinish; i++)
            {
                arraySpiralVoid[i,j] = count;
                count++;
            }
            jFinish = jFinish - 1;
            iCurrent = iFinish;
            jCurrent = jFinish;
        }

        if(iCurrent == iFinish && jCurrent == jFinish)
        {
            for(int j = jCurrent-1, i = iCurrent-1; j >= jStart; j--)
            {
                arraySpiralVoid[i, j] = count;
                count++;
            }
            iFinish = iFinish - 1;
            iCurrent = iFinish;
            jCurrent = jStart;
        }

        if(iCurrent == iFinish && jCurrent == jStart)
        {
            for(int i = iCurrent-1, j = jCurrent; i >= iStart; i--)
            {
                arraySpiralVoid[i, j] = count;
                count++;
            }
            jStart = jStart+1;
            iCurrent = iStart;
            jCurrent = jStart;
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

int m = 5;
int n = 5;
int[,] array = new int[m,n];

arraySpiralFilling(array);
arrayPrint(array);
System.Console.WriteLine();
System.Console.WriteLine();