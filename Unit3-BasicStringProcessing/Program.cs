bool doAgain = false;
do
{
    Console.Write("Please enter a sentance:");
    string userSentance = Console.ReadLine();
    string[] words = userSentance.Split(' ');

    foreach (string word in words)
    {
        Console.WriteLine(word);
    }

    Console.WriteLine("Would you like to go again (y/n)?");
    string userInput = Console.ReadLine();
    if (userInput == "y")
    {
        doAgain= true;
    }
    else
    {
        doAgain= false;
    }
} while (doAgain == true);

doAgain= false;
List<string> strings= new List<string>();
Console.WriteLine("\n\n");
do
{
    Console.WriteLine("Enter some text: ");
    strings.Add(Console.ReadLine());
    Console.WriteLine("You have entered: ");
    foreach (string word in strings)
    {
        Console.Write(word + " ");
    }
    Console.WriteLine("\n");
    Console.WriteLine("Would you like to continue (y/n)?");
    string userInput = Console.ReadLine();

    if (userInput == "y")
    {
        doAgain = true;
    }
    else
    {
        doAgain = false;
    }
} while (doAgain == true);
Console.WriteLine("Goodbye!");