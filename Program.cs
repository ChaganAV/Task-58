// Создадим массив через random
Random rnd = new Random();
int minR = 2; int maxR = 5;
int rows = rnd.Next(minR,maxR); int columns = rows+2; // строки и колонки массива 
int rowC = 0;
int[,] matrixA = new int[rows,columns]; // массив A
int[,] matrixB = new int[columns,rows]; // массив B
if (rows<columns)
    rowC = rows;
else
    rowC = columns;
int[,] matrixC = new int[rows,columns];
int minRnd = 1; int maxRnd = 10; // для random
int[,] test1 = {{2,4},{3,2}};
int[,] test2 = {{3,4},{3,3}};
int[,] test3 = new int[2,2];
//
/*FillRandomArray(matrixA);
Print2DArray(matrixA);

Console.WriteLine();
FillRandomArray(matrixB);
Print2DArray(matrixB);

PowerMatrix(matrixA,matrixB,matrixC);*/
PowerMatrix(test1,test2,test3);
Console.WriteLine();

//Print2DArray(matrixC);
Print2DArray(test3);


// Функции
void PowerMatrix(int[,] A, int[,] B, int[,] C)
{
    for(int Ci = 0; Ci < C.GetLength(0); Ci++)
    {
        for(int Cj = 0; Cj < C.GetLength(1); Cj++)
        {   
            Console.Write($"C[{Ci},{Cj}] = ");
            for(int j = 0; j < A.GetLength(1); j++)
            {  
                
                C[Ci,Cj]+= A[Ci,j]*B[j,Cj];
                Console.Write($" + A[{Ci},{j}]*B[{j},{Cj}]");
                
            }
            Console.WriteLine(); 
        }
    }
}
    

void FillRandomArray(int[,] array)
{
    Random rnd = new Random();
    for(int row = 0; row < array.GetLength(0); row++)
    {
        for(int col = 0; col < array.GetLength(1); col++)
        {
            array[row,col] = rnd.Next(minRnd,maxRnd);
        }
    }
}

void Print2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {            
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}