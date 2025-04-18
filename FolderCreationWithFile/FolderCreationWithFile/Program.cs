namespace FolderCreationWithFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;

            //Define the Folder and File Name
            string folderName = "NewFolder";
            string fileName = "MyFile.txt";
            string folderPath = Path.Combine(currentDirectory, folderName);
            string filePath = Path.Combine(folderPath, fileName);

            try
            {
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                    Console.WriteLine($"Folder Created : {folderPath}");
                }

                string fileContenct = "Hi This is a new File";
                File.WriteAllText(filePath, fileContenct);
                Console.WriteLine($"File Created : {filePath}");
                Console.ReadKey();
            }catch(Exception ex)
            {
                Console.WriteLine($"Error in Creation of File {ex.Message}");
            }
        }
    }
}
