// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию 
//элементы каждой строки двумерного массива.

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
void PrintArray(int[,] array)
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

int[,] MatrixLineArange(int[,] matrix)
{
    int[,] matrixLineArange = new int[matrix.GetLength(0), matrix.GetLength(1)];
   
   for (int i = 0; i < matrix.GetLength(0); i++)
        {
        
            for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int maxOfLine = matrix[i,j];
                    for (int k = j; k < matrix.GetLength(1)-1; k++)
                    {
                        if (maxOfLine <= matrix[i, k+1])
                            {   
                                maxOfLine = matrix[i,k+1];
                                int temporary = matrix [i,j];
                                matrix[i,j] = matrix[i,k+1];
                                matrix[i,k+1] = temporary;
                            }
                    }  
                    matrixLineArange[i, j] = matrix[i,j];
                    }
        }
    return matrixLineArange;
}
int[,] matrix = GetMatrix(10, 8);
PrintArray(matrix);
Console.WriteLine();
int[,] matrix2 = MatrixLineArange(matrix);
PrintArray(matrix2);

