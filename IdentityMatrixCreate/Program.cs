
Console.WriteLine("Please Enter the Size of Identity matrix you want to create");
int size = int.Parse(Console.ReadLine());

int[,] identityMatrix = CreateIdentityMatrix(size);


// Print the identity matrix
PrintMatrix(identityMatrix);



static int[,] CreateIdentityMatrix(int size)
{
    int[,] matrix = new int[size, size];

    for(int i =0; i<size; i++)
    {

        matrix[i, i] = 1;
    }
    return matrix;
}


static void PrintMatrix(int[,] identityMatrix)
{   
    int rows = identityMatrix.GetLength(0);
    int cols = identityMatrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write(identityMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

Console.ReadKey();