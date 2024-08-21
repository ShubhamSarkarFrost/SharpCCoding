static int BinarySearch(int[] array, int target)
{
    int left = 0;
    int right = array.Length - 1;

    while (left <= right)
    {
        int mid = left + (right - left) / 2;

        if (array[mid] == target)
            return mid;

        if (array[mid] < target)
            left = mid + 1;
        else
            right = mid - 1;
    }

    return -1;
}

Console.WriteLine("Enter the number of elements in the array:");
int n = int.Parse(Console.ReadLine());

int[] array = new int[n];

Console.WriteLine("Enter the elements of the array (in sorted order):");
for (int i = 0; i < n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

// Taking the target element to search
Console.WriteLine("Enter the element to search:");
int target = int.Parse(Console.ReadLine());

// Performing binary search
int result = BinarySearch(array, target);

if (result != -1)
    Console.WriteLine($"Element found at index {result}");
else
    Console.WriteLine("Element not found in the array");


Console.ReadKey();