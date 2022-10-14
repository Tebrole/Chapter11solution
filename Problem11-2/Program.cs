//Write a program, which generates and prints 10 random numbers in range [100, 200]

Random numb = new Random();
for (int i = 0; i < 10; i++)
{
    int randNum = numb.Next(100, 201);
    Console.Write("{0} ", randNum);
}
