Console.Write("Enter the number of elements in the array: ");
int n = int.Parse(Console.ReadLine());

// Input the array elements
int[] array = new int[n];
Console.WriteLine("Enter the elements of the array:");
for (int i = 0; i < n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

// Input the position of the element to be deleted
Console.Write("Enter the position of the element to delete (1 to {0}): ", n);
int position = int.Parse(Console.ReadLine()) - 1;

if(position <0 || position > n)
{
    Console.WriteLine("Invalid Index Position");
}

for(int i = position; i <n -1; i++)
{
    array[i] = array[i + 1];
}

for(int i = 0; i< n-1; i++)
{
    Console.WriteLine(array[i]);
}