Console.WriteLine("Please enter the Year");
int year = int.Parse(Console.ReadLine());
Console.WriteLine("Please enter the century which you think it is");
int century = int.Parse(Console.ReadLine());

Console.WriteLine(centuryFromYear(year) == century);


static int centuryFromYear(int year)
{
    return (int)(year / 100) + ((year % 100 == 0)? 0: 1);
}

Console.ReadKey();


