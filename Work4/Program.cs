// Сформируйте трехмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив,
//добавляя индексы каждого элемента.
int[, ,] GetMatrix(int a, int b, int c)
{
    int[] array = new int[a*b*c];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(10,100);
        if(i!=0)
        {
            for (int j = 0; j < i; j++)
            {
                while(array[i] == array[j])
                {
                    array[i] = rnd.Next(10,100);
                    j=0;
                }
            }
        }
    }
    int idxArray = 0;
    int[, ,] matrix = new int[a, b, c];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = array[idxArray];
                idxArray++;
                
            }
        }
    }
    return matrix;
}

void PrintArray3d(int[, ,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k <  array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
            }
            
        } 
        
    }
    
} 

int [, ,] matrix = GetMatrix(3,3,4);
PrintArray3d(matrix);



