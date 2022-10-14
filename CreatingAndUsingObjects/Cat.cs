namespace CreatingAndUsingObjects;

public class Cat
{
    public string name;
    public string color;

    public Cat(string name, string color)
    {
        this.name = name;
        this.color = color;
    }

    public void sayMiau()
    {
        Console.WriteLine("{0}: Miauu", name);
    }
}

