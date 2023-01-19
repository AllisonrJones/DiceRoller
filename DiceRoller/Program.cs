
using System;
bool run = true;
Console.WriteLine("Welcome, how many sides are on your dice?");

    int diceValue = 0;
    while (int.TryParse(Console.ReadLine(), out diceValue) == false)
    {
        Console.WriteLine("That's is not a valid input, please enter the NUMBER of sides on your dice.");

    }

while (true)
{
    if (diceValue == 6)
    {
        Console.WriteLine("Please type 'ROLL' to roll your dice.");
    }
    else
    {
        Console.WriteLine("I'm sorry this game is made for six-sided dice; come back when you've got the goods");
        break;
    }

    if (Console.ReadLine().ToLower() == "roll")
    {
        int die1 = 0;
        int die2 = 0;

        static int GetRandom(int diceValue)
        {
            Random r = new Random();
            return r.Next(1, diceValue + 1);
        }
        die1 = GetRandom(diceValue);
        die2 = GetRandom(diceValue);
        int Total = die1 + die2;
        Console.WriteLine($"You rolled a {die1} and a {die2} a total of {Total}");

        switch (Total)
        {
            case 2:
                Total = 2;
                Console.WriteLine("Two 1's! SNAKE EYES");
                Console.WriteLine("... and CRAPS!!");
                break;
            case 3:
                Total = 3;
                Console.WriteLine("A 1 & a 2! ACE DEUCE");
                Console.WriteLine("... and CRAPS!!");
                break;
            case 12:
                Total = 12;
                Console.WriteLine("Two 6's! BOX CARS");
                Console.WriteLine("...and CRAPS!!");
                break;
            case 7:
                Total = 7;
                Console.WriteLine("A 7! You WIN!");
                break;
            case 11:
                Total = 11;
                Console.WriteLine("An 11! You WIN!");
                break;
            default:
                break;
        }
        Console.WriteLine("Would you like to roll again? y/n");
   


    string response = Console.ReadLine().ToLower();
    if (response == "y")
    {
        run = true;
    }
    else if (response == "n")
    {
        run = false;
            break;
    }
    else
    {
        Console.WriteLine("Press any key to start again");
    }

}
    else
    {
        Console.WriteLine("That is not a valid entry");
    }
}
   


    






















