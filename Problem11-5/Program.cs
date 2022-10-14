// See https://aka.ms/new-console-template for more information

//Find the hypotenuse of a right triangle. Implement lengths of the sides from input. 

//assuming we want precision to decimals. 
Console.WriteLine("Enter the length of the 1st side: ");
double x1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the length of the 2nd side: ");
double x2 = double.Parse(Console.ReadLine());

double hypotenouseSquared = Math.Pow(x1, 2) + Math.Pow(x2, 2);
double hypotenouse = Math.Sqrt(hypotenouseSquared); 

Console.WriteLine("Hypothenouse of the given triangle is {0}", hypotenouse);
