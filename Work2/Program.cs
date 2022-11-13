//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
//строку с наименьшей суммой элементов.
//Программа должна выдавать номер строки с наименьшей суммой.
int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(2, 10);
        }
    }
    return matrix;
}
void PrintArrayMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
}
void LinesOfMinSum (int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int lineSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            lineSum = lineSum + matrix[i,j];
        }
        array[i] = lineSum;
        Console.Write($"{array[i]} ");
        lineSum = 0;
    }

    int indexMin = 0;
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] < min)
            {
                min = array[i];
                indexMin = i; 
            }
    }
    Console.WriteLine();
    Console.WriteLine($"Номер строки с минимальной суммой = {indexMin + 1} ");
}



int [,] matrix = GetMatrix(6,6);
PrintArrayMatrix(matrix);
Console.WriteLine();
LinesOfMinSum(matrix);



