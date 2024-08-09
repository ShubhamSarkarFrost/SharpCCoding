int maxnum = int.MaxValue;
int minnum = int.MinValue;

int secondMax = int.MinValue;
int secondMin = int.MaxValue;


Console.WriteLine("Please Enter the number of elements you want to enter in an array");
int elements = int.Parse(Console.ReadLine());

int[] arr = new int[elements];

for(int i = 0; i< elements; i++)
{
    Console.WriteLine($"Please Enter the {i + 1} element");
    arr[i] = int.Parse(Console.ReadLine());

}

foreach (int num in arr)
{
    if(num > maxnum)
    {
        secondMax = maxnum;
        maxnum = num;
    }else if(num > secondMax && num != maxnum)
    {
        secondMax = num;
    }

    if (num < minnum)
    {
        secondMin = minnum;
        minnum = num;
    }else if(num < secondMin && num != minnum)
    {
        secondMin = num;
    }

    //Console.WriteLine("Maximum value: " + maxnum);
    //Console.WriteLine("Minimum value: " + minnum);
    Console.WriteLine("Second Maximum value: " + secondMax);
    Console.WriteLine("Second Minimum value: " + secondMin);
}

Console.ReadKey();
