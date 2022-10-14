// See https://aka.ms/new-console-template for more information

//Write a program which creates 10 objects of type Cat, gives them names CatN, where N is a unique
//serial number, and call the method SayMiau() for each. 

using System;
using CreatingAndUsingObjects;

for (int i = 0; i < 10; i++)
{
    Cat newCat = new Cat("Bobby", "Brown");
    newCat.sayMiau();
}