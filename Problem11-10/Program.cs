// See https://aka.ms/new-console-template for more information

//You are given a sequence of positive integer numbers as a string where numbers are separated by space.
//Calculate the sum of the numbers. 

Console.WriteLine("Enter the numbers separated by space: ");
string numbers = Console.ReadLine();



string[] splitNum = numbers.Split(' ');

int sum = 0;
for (int i = 0; i < splitNum.Length; i++)
{
    int x = Convert.ToInt32(splitNum[i]);
    sum = sum + x;
}

Console.WriteLine("The sum of the input is {0}", sum);
