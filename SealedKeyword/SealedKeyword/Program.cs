namespace SealedKeyword
{
    sealed class FinalClass // Sealed class
    {
        public void ShowMessage()
        {
            Console.WriteLine("This is a sealed class.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            FinalClass obj = new FinalClass();
            obj.ShowMessage();
            Console.ReadKey();
        }
    }
}
