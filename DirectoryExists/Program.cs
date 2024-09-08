Console.WriteLine("Please Enter the Directory in which files have to be checked");
string directory_path = Console.ReadLine();

if (Directory.Exists(directory_path))
{  
    //get the Directory Info
    DirectoryInfo directoryInfo = new DirectoryInfo(directory_path);
    //get the filrs in directory
    FileInfo[] files = directoryInfo.GetFiles();
    //sort the file
    var sorted_files = files.OrderBy(files => files.CreationTime);

    //display the file using the loop
    foreach(var file in sorted_files)
    {
        Console.WriteLine($"{file.Name}: Created on ${file.CreationTime}");
    }
}
else
{
    Console.WriteLine("The Given directory does not exist");
}

Console.ReadKey();


