namespace CreatingAndUsingObjects;

public class Sequence
{
    private static int currentValue = 0;

    public Sequence()
    {
    }

    public static int NextValue()
    {
        currentValue++;
        return currentValue;
    }

}