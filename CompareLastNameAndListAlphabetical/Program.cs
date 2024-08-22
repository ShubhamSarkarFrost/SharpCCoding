// Input the full names of two people
Console.Write("Enter the full name of the first person: ");
string name1 = Console.ReadLine();

Console.Write("Enter the full name of the second person: ");
string name2 = Console.ReadLine();

// Extract the last names
string lastName1 = GetLastName(name1);
string lastName2 = GetLastName(name2);

if(string.Compare(lastName1, lastName2) < 0)
{
    Console.WriteLine($"Names in alphabetical order: \n1. {name1}\n2. {name2}");
}
else if(string.Compare(lastName1, lastName2) > 0)
{
    Console.WriteLine($"Names in alphabetical order: \n1. {name2}\n2. {name1}")
}else
{
    Console.WriteLine($"Both names are in equal Order: \n1. {name2}\n2. {name1}")
}

static string GetLastName(string name)
{
    string[] names_arr = name.Split(" ");

    return names_arr[names_arr.Length - 1];
}
