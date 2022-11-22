// Создадим массив через random
Random rnd = new Random();
int minR = 1; int maxR = 10;
int rows = rnd.Next(minR,maxR); int columns = rows+2; // строки и колонки массива 
int rowC = 0;
int[,] matrixA = new int[rows,columns]; // массив A
int[,] matrixB = new int[columns,rows]; // массив B
if (rows<columns)
    rowC = rows;
else
    rowC = columns;
int[,] matrixC = new int[rowC,rowC];
int minRnd = 1; int maxRnd = 10; // для random
//
FillRandomArray(matrixA);
Print2DArray(matrixA);

Console.WriteLine();
FillRandomArray(matrixB);
Print2DArray(matrixB);

PowerMatrix(matrixA,matrixB,matrixC);
Console.WriteLine();

Print2DArray(matrixC);


// Функции
void PowerMatrix(int[,] A, int[,] B, int[,] C)
{
    for(int Ai = 0; Ai < A.GetLength(0); Ai++)
    {
        for(int Aj = 0; Aj < A.GetLength(1); Aj++)
        {   
            for(int Bj = 0; Bj < B.GetLength(1); Bj++)
            {
                for(int Bi = 0; Bi < B.GetLength(0); Bi++)
                {  
                    
                    C[Ai,Bj]+= A[Ai,Aj]*B[Bi,Bj];
                    Console.Write($"C[{Ai},{Bj}]+=A[{Ai},{Aj}]*B[{Bi},{Bj}]");
                    Console.WriteLine();
                }
            }
            /*C[Ai,Bj]+= A[Ai,Aj]*B[Bi,Bj];
            Console.Write($"C[{Ai},{Bj}]+=A[{Ai},{Aj}]*B[{Bi},{Bj}]");
            Console.WriteLine();*/
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