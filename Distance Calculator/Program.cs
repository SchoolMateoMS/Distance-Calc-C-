//Init stuff
Console.Clear();
#nullable disable

//Welcome
Console.WriteLine("Welcome to the DISTANCE CALCULATOR");

//Input
Console.WriteLine("Enter x1 value");
double x1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter y1 value");
double y1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter x2 value");
double x2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter y2 value");
double y2 = Convert.ToDouble(Console.ReadLine());


//Process
double process = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

//Output
Console.WriteLine($"Distance between the two points is {process}");