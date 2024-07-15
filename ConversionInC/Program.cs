//Implicit casting 
int myInt = 9;
double myDouble = myInt;       // Automatic casting: int to double

Console.WriteLine(myInt);      // Outputs 9
Console.WriteLine(myDouble);   // Outputs 9

//Explicit Casting
double myDouble3 = 9.78;
int myInt3 = (int)myDouble;    // Manual casting: double to int

Console.WriteLine(myDouble3);   // Outputs 9.78
Console.WriteLine(myInt3);      // Outputs 9

//Type Conversion Method
int myInt2 = 10;
double myDouble2 = 5.25;
bool myBool = true;

Console.WriteLine(Convert.ToString(myInt2));    // convert int to string
Console.WriteLine(Convert.ToDouble(myInt2));    // convert int to double
Console.WriteLine(Convert.ToInt32(myDouble2));  // convert double to int
Console.WriteLine(Convert.ToString(myBool));   // convert bool to string

//implicitely typed variable 
var myNumber = 13;
Console.WriteLine(myNumber.GetType());

Console.ReadKey();
