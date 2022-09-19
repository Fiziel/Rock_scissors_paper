// See https://aka.ms/new-console-template for more information
Random rand = new Random();
string[] arr = new string[] { "Rock", "Scissors", "Paper" };
while (true) 
{
    Console.Write("0 - Rock\n1 - Scissors\n2 - Paper\n[0-2] ");
    var userInput = Convert.ToInt32(Console.ReadLine());
    if (userInput >= 0 && userInput < 3)
    {
        var compInput = rand.Next(3);
        Console.WriteLine("Your choice is: {0}", arr[userInput]);
        Console.WriteLine("Computer choice is: {0}", arr[compInput]);
        if (userInput == compInput)
        {
            Console.WriteLine("Draw\n");
        }
        else if (userInput == 0 && compInput == 1)
        {
            Console.WriteLine("You win\n");
        }
        else if (userInput == 1 && compInput == 2)
        {
            Console.WriteLine("You win\n");
        }
        else if (userInput == 2 && compInput == 1)
        {
            Console.WriteLine("You win\n");
        }
        else
        {
            Console.WriteLine("Computer wins\n");
        }        
    }
    else
    {
        Console.WriteLine("Try again!\n");
    }
}