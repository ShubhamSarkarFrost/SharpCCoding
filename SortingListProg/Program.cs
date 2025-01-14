namespace SortingListProg
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // take data from the User
            Console.WriteLine("Enter the Data in String Value in the List {Type done to Finish}");
            List<string> newList = new List<string>();
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (input.ToLower() == "done")
                    break;
                newList.Add(input);
            }

            // take the input of sorting method from the user
            Console.WriteLine("Please enter the sorting method asc - Ascending or dsc - decending");
            string sorting_method = Console.ReadLine()?.ToLower();

            if(sorting_method == "asc")
            {
                newList = newList.OrderBy(s => s).ToList();
            }else if(sorting_method == "dsc")
            {
                newList = newList.OrderByDescending(s => s).ToList();
            }
            else
            {
                Console.WriteLine("Invalid sorting method. Defaulting to ascending order.");
                newList = newList.OrderBy(s => s).ToList();
            }

            // Step 4: Print the sorted list
            Console.WriteLine("Sorted list:");
            foreach (var str in newList)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }


    }
    
}
