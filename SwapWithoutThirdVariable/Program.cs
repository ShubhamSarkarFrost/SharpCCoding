Console.WriteLine("Please Enter the First Number");
int num_one = int.Parse(Console.ReadLine());
Console.WriteLine("Please Enter the Second Number");
int num_two = int.Parse(Console.ReadLine());

int sum = 0;
Console.WriteLine($"Before First Number is : {num_one} ");
Console.WriteLine($"Before Second Number is : {num_two} ");

sum = num_one + num_two;
num_one = sum - num_one;
num_two = sum - num_two;

Console.WriteLine($"After First Number is : {num_one} ");
Console.WriteLine($"After Second Number is : {num_two} ");

Console.ReadKey();


