//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

static int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void arrayFilling(int[,,] arrayFillVoid, int m, int n, int k)
{
    int[] arrayCompleted = new int[m*n*k];
    for(int index = 0; index < arrayCompleted.Length; index++)
    {
        arrayCompleted[index] = index;
    }

    Random digit = new Random();
    int arraySize = arrayCompleted.Length-1;
    for (int z = 0; z < arrayFillVoid.GetLength(2); z++)
    {
        for (int i = 0; i < arrayFillVoid.GetLength(0); i++)
        { 
            for(int j = 0; j < arrayFillVoid.GetLength(1); j++)
            {
                int randomPosition = digit.Next(0, arraySize);
                arrayFillVoid[i, j, z] = arrayCompleted[randomPosition];
                int digitTemporary = arrayCompleted[arraySize];
                arrayCompleted[arraySize] = arrayCompleted[randomPosition];
                arrayCompleted[randomPosition] = digitTemporary;
                arraySize = arraySize - 1;
            }
        }
    }
}

static void arrayPrint(int[, ,] arrayPrintVoid)
{
    for (int z = 0; z < arrayPrintVoid.GetLength(2); z++)
    {
        for (int i = 0; i < arrayPrintVoid.GetLength(0); i++)
        {
            System.Console.WriteLine();
            for (int j = 0; j < arrayPrintVoid.GetLength(1); j++)
            {
                System.Console.Write("|{0:d2}| ({1}, {2}, {3})  ", arrayPrintVoid[i, j, z], i, j, z);
            }
        }
        System.Console.WriteLine();
    }
}

System.Console.WriteLine();
int m = Prompt("Input amount of array rows? - ");
int n = Prompt("Input amount of array columns? - ");
int k = Prompt("Input amount of line array in third plane space? - ");

int[,,] array = new int[m, n, k];
arrayFilling(array, m, n, k);
arrayPrint(array);
System.Console.WriteLine();