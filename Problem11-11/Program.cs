// See https://aka.ms/new-console-template for more information

//Write a program to generate random message from predefined lists. 


string[] phrases = new string[] {"The product is excellent.", "This is a great product.", "I use this product constantly.", "This is the best product from this category."};
string[] stories = new string[] {"Now I feel better.", "I managed to change.", "It made some miracle.", "I can’t believe it, but now I am feeling great.", "You should try it, too. I am very satisfied."};
string[] firstNames = new string[] {"Dayan", "Stella", "Hellen", "Kate"};
string[] lastNames = new string[] {"Johnson", "Peterson", "Charles"};
string[] cities = new string[] {"London", "Paris", "Berlin", "New York", "Madrid"};

Random random = new Random();

string phrase = phrases[random.Next(5)];
string story = stories[random.Next(5)];
string firstName = firstNames[random.Next(4)];
string lastName = lastNames[random.Next(3)];
string city = cities[random.Next(5)];

Console.WriteLine("{0} {1}\n-- {2} {3}, {4}. ", phrase, story, firstName, lastName, city);

