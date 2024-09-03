//Creating an Array List to Store the Elements 
using System.Collections;

ArrayList stringlist = new ArrayList();

Console.WriteLine("Please Enter the Number of Elements to Store");
int countelem = int.Parse(Console.ReadLine());

for(int i = 0; i< countelem; i++)
{
    Console.Write($"Enter input {i + 1}: ");
    string userInput = Console.ReadLine();
    stringlist.Add(userInput);
}

//Iterate through Elements 
foreach(string item in stringlist)
{

    Console.WriteLine(item);
}

Console.ReadKey();
