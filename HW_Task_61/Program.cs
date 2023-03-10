//Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

//Количество строк в треугольнике равно количеству столбцов

static int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

static void arrayPascalTriangleFilling(int[,] arrayPTFVoid)
{
     int[] arrayTemporaryPast = {1, 1};
    for (int i = 0; i < arrayPTFVoid.GetLength(0); i++)
    {
        int[] arrayTemporaryCurrent = new int[i+1];
        int index = 0;
        for (int j = 0; j<i+1; j++)
        {
            if(j==0 || j == i)
            {
                arrayPTFVoid[i,j] = 1;
            }
            else
            {
                arrayPTFVoid[i,j] = arrayTemporaryPast[index-1] + arrayTemporaryPast[index];
            }
            arrayTemporaryCurrent[index] = arrayPTFVoid[i,j];
            index = index + 1;
        }
        arrayTemporaryPast = arrayTemporaryCurrent;
    }
}

static void arrayPrint(int[,] arrayPrintVoid)
{
    for(int i = 0; i<arrayPrintVoid.GetLength(0); i++)
    {
        System.Console.WriteLine();
        int center = Console.WindowWidth / 2;
        int left = center - (2*i+1)/2;
        int top = Console.CursorTop;
        Console.SetCursorPosition(left, top);
        
        for (int j = 0; j<arrayPrintVoid.GetLength(1); j++)
        {
            if(arrayPrintVoid[i,j] != 0)
            {
                System.Console.Write("{0:d2} ", arrayPrintVoid[i,j]);
            }
        }
    }
}

int N = Prompt("Input amount of rows in Pascal Triangle: ");
int[,] array = new int[N, N];
arrayPascalTriangleFilling(array);
System.Console.WriteLine();
arrayPrint(array);
System.Console.WriteLine();