using ElephantProgram;

Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };

Console.WriteLine("Press 1 for LLoyd, 2 for Lucinda, 3 to swap references");

while (true)
{
    string? decision = Console.ReadLine();

    if (int.TryParse(decision, out var result) && result == 1 || result == 2 || result == 3)
    {
        if (result == 1)
        {
            Console.WriteLine("You pressed 1");
            Console.WriteLine("Calling Lloyd");
            lloyd.WhoAmI();
        }
        else if (result == 2)
        {
            Console.WriteLine("You pressed 2");
            Console.WriteLine("Calling Lucinda");
            lucinda.WhoAmI();
        }
        else if (result == 3)
        {
            Console.WriteLine("References have been swapped");

            //created a temp object to store the lloyd reference to complete swap
            Elephant temp;
            temp = lloyd;
            lloyd = lucinda;
            lucinda = temp;


        }
    }

    else
    {
        Console.WriteLine("You did not enter a valid value");
        return;
    }
}