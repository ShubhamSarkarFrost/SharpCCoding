
Console.WriteLine("Please Enter a Valid String");
string original_string = Console.ReadLine();

string Reversed = reversed(original_string);

if (original_string.Equals(Reversed))
{
    Console.WriteLine($"The Words are Plaindromic {original_string} , {Reversed}");
}
else
{
    Console.WriteLine($"The Words are not Plaindromic {original_string} , {Reversed}");
}

bool is_palin = checkpalin(original_string);

if (is_palin)
{
    Console.WriteLine($"The Words are Plaindromic {original_string} , {Reversed}");
}else
{
    Console.WriteLine($"The Words are not Plaindromic {original_string} , {Reversed}");
}


static string reversed(string original_string)
{
    string reverse = ""; 
   for(int i= original_string.Length -1; i >=0; i--)
    {
        reverse = reverse + original_string[i];
    }  

   return reverse;
}


static bool checkpalin(string original_string)
{
    int start = 0;
    int end = original_string.Length -1;

    while(start < end)
    {
        if(original_string[start] != original_string[end])
        {
            return false;
           
        }
        start++;
        end--;
    }

    return true;
}

Console.ReadKey();