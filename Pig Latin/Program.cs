bool loop = true;
Console.WriteLine("Welcome to the Pig Latin Translator!");
do
{

    Console.WriteLine("Enter a line to be translated:");
    string input = Console.ReadLine().ToLower().Trim();
    string[] words = input.Split(' ').ToArray();
    if (input[0] == 'a' || input[0] == 'e' || input[0] == 'i' || input[0] == 'o' || input[0] == 'u')
    {
        Console.WriteLine(input + "way");
        Console.WriteLine("Translate another line? (y/n)");
        string userChoice = Console.ReadLine().ToLower().Trim();
        if (userChoice == "y")
        {
            loop = true;
        }
        else if (userChoice == "n")
        {
            Console.WriteLine("Goodbye!");
            loop = false;
        }
        else
        {
            Console.WriteLine("Please enter a valid choice");
            loop = true;
        }
    }
    else
    {
        for (int i = 0; i < input.Length; i++)
        {
            string firstWord = input.Substring(0, i);
            string secondWord = input.Substring(i);
            if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
            {
                Console.WriteLine(secondWord + firstWord + "ay");
                break;
            }
            
        }
            Console.WriteLine("Translate another line? (y/n)");
            string userChoice = Console.ReadLine().ToLower().Trim();
            if (userChoice == "y")
            {
                loop = true;
            }
            else if (userChoice == "n")
            {
                Console.WriteLine("Goodbye!");
                loop = false;
            }
            else
            {
                Console.WriteLine("Please enter a valid choice");
                loop = true;
            }
        }
    
    
} while (loop != false) ;