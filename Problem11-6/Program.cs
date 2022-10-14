//Write a program that calculates area of the triangle from (a) 3 sides 


Console.WriteLine("Enter the length of the 1st side: ");
float x1 = float.Parse(Console.ReadLine());
Console.WriteLine("Enter the length of the 2nd side: ");
float x2 = float.Parse(Console.ReadLine());
Console.WriteLine("Enter the length of the 3rd side: ");
float x3 = float.Parse(Console.ReadLine());

float p = (x1 + x2 + x3) / 2;
float areaSquared = p * (p - x1) * (p - x2) * (p - x3);
double area = Math.Sqrt(areaSquared);

Console.WriteLine("The area of the triangle is {0}", area);

// (b) side and the altitude to it; 
Console.WriteLine("Enther the length of the side: ");
float y1 = float.Parse(Console.ReadLine());
Console.WriteLine("Enther the altitude: ");
float y2 = float.Parse(Console.ReadLine());

Console.WriteLine("The area of the triangle is {0}", y1*y2/2);

// (c) 2 sides and the angle between them in degrees; 
Console.WriteLine("Enther the length of the 1st side: ");
float z1 = float.Parse(Console.ReadLine());
Console.WriteLine("Enther the length of the 2nd side: ");
float z2 = float.Parse(Console.ReadLine());
Console.WriteLine("Enter the angle in degrees: ");
float z3 = float.Parse(Console.ReadLine());

Console.WriteLine("The area of the triangle is {0}", z1*z2*System.Math.Sin(z3)/2);