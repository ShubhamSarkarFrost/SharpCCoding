Console.WriteLine("Please Enter the Year to Check Leap Year or Not");
int year = int.Parse(Console.ReadLine());

if (IsLeapYear(year))
{
    Console.WriteLine("is a Leap Year" + year);
}
else
{
    Console.WriteLine("is not a Leap Year" + year);
}

static Boolean IsLeapYear(int year)
{
    if (year % 4 == 0)
    {
        if (year % 100 == 0)
        {
            if (year % 400 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }
    else
    {
        return false;
    }
}

