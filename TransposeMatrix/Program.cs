// Input matrix dimensions
Console.Write("Enter the number of rows: ");
int rows = int.Parse(Console.ReadLine());

Console.Write("Enter the number of columns: ");
int columns = int.Parse(Console.ReadLine());

// Declare and initialize the matrix
int[,] matrix = new int[rows, columns];

// Input matrix elements
Console.WriteLine("Enter the elements of the matrix:");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = int.Parse(Console.ReadLine());
    }
}

// Display the original matrix
Console.WriteLine("\nOriginal Matrix:");
DisplayMatrix(matrix, rows, columns);

// Find the transpose of the matrix
int[,] transpose = TransposeMatrix(matrix, rows, columns);





static int[,] TransposeMatrix(int[,] matrix, int rows, int columns)
{
    // Create a new matrix to store the transpose
    int[,] transpose = new int[columns, rows];
    for (int i = 0; i < rows; ++i)
    {
        for (int j = 0; ++j < columns; ++j)
        {

            transpose[j, i] = matrix[i, j];
        }
    }
    return transpose;
}


//Display the MATRIX
static void DisplayMatrix(int[,] matrix, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
    }
}
