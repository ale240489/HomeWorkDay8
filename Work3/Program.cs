//Задайте две матрицы. Напишите программу, которая будет находить
//произведение двух матриц.

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
int[,] GetMatrixResult (int[,] array, int[,] array2)
{
    int[,] resultMatrix = new int[array2.GetLength(0),array2.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(0); j++)
        {
            for (int k = 0; k < resultMatrix.GetLength(0); k++)
            {
                resultMatrix[i,j] = resultMatrix[i,j] + array[i,k]*array2[k,j];
            }
        }
    }
    return resultMatrix;
}
int [,] matrix = GetMatrix(2,2);
int [,] matrix2 = GetMatrix(2,2);
PrintArray(matrix);
Console.WriteLine();
PrintArray(matrix2);
Console.WriteLine();
int[,] resultMatrix = GetMatrixResult(matrix, matrix2);
PrintArray(resultMatrix);