namespace LCM_GCD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the First Number");
            int num_first = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Second Number");
            int num_two = int.Parse(Console.ReadLine());
            int gcd = GCD(num_first, num_two);
            Console.WriteLine($"{num_first} and ${num_two} GCD is ${gcd}");
            int lcm = LCM(num_first, num_two);
            Console.WriteLine($"{num_first} and ${num_two} LCM is ${lcm}");
            Console.ReadKey();
        }

        static int GCD(int num_first, int num_two)
        {
            while (num_two != 0)
            {
                int temp = num_two;
                num_two = num_first % num_two;
                temp = num_first;

            }
            return num_first;
        }


        static int LCM(int num_first, int num_two)
        {
            return (num_first * num_two) / GCD(num_first, num_two);
        }
    }
}
