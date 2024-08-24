
Console.WriteLine("Please Enter the number of elements you want to enter in an array");
int elements = int.Parse(Console.ReadLine());

int[] arr = new int[elements];

for (int i = 0; i < elements; i++)
{
    Console.WriteLine($"Please Enter the {i + 1} element");
    arr[i] = int.Parse(Console.ReadLine());

}

int lowest = int.MaxValue;
int second_lowest = int.MaxValue;

foreach(int num in arr)
{
    if(num < lowest)
    {
        second_lowest = lowest;
        lowest = num;
    }
    else if(num <second_lowest && num != second_lowest)
    {
        second_lowest = num;
    }
}

if(lowest == int.MaxValue || second_lowest == int.MaxValue)
{
    Console.WriteLine("Not enough negative numbers in the array.");
}else
{
    int sum = lowest + second_lowest;
    Console.WriteLine("The sum of the two lowest negative numbers is: " + sum);
}
