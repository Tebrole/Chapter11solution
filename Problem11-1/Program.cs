// See https://aka.ms/new-console-template for more information

//Write a program that reads a year from the console and checks if it's a leap year 

Console.WriteLine("Enter the year: ");
int year = int.Parse(Console.ReadLine());

if (DateTime.IsLeapYear(year))
{
    Console.WriteLine("{0} is a leap year", year);
}
else
{
    Console.WriteLine("{0} is not a leap year", year);
}