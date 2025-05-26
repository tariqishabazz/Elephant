namespace ElephantProgram;

internal class Elephant
{
    public int EarSize;
    public string Name = "";

    public Elephant() { }

    public void WhoAmI()
    {
        Console.WriteLine("My name is " + Name + ".");
        Console.WriteLine("My ears are " + EarSize + " inches tall.");
    }
}
