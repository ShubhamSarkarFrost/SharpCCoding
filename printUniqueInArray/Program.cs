// Input the array size
Console.Write("Enter the number of elements in the array: ");
int n = int.Parse(Console.ReadLine());

// Input the array elements
int[] array = new int[n];
Console.WriteLine("Enter the elements of the array:");
for (int i = 0; i < n; i++)
{
    array[i] = int.Parse(Console.ReadLine());
}

// Find and print unique elements
PrintUniqueElements(array);


static void PrintUniqueElements(int[] array)
{
    Dictionary<int,int> frequencyMap = new Dictionary<int,int>();

    foreach(int elem in array)
    {   
        //check whether the element is Present
        if (frequencyMap.ContainsKey(elem))
        {   
            //If Present Maximaze the Count
            frequencyMap[elem]++;
        }
        // elese just make the new unique element count as one
        frequencyMap[elem] = 1;
    }

    Console.WriteLine("All the Unique Elements are:");
    //now print all the unique values
    foreach (var pair in frequencyMap)
    {
        if(pair.Value == 1)
        {
            Console.Write(pair.Key);
        }
    }
}

Console.ReadKey();