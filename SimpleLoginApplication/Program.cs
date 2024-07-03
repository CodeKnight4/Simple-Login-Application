string user_name = "test123";
string password = "extremepass321";

string title_string = $"""
    * * * * * * * * * * * * * * * * * * * * * 
    *                                       *
    *    -      ---    ---   ---  -    -    *
    *    |     |   |  |       |   | \  |    *
    *    |     |   |  |  --   |   |  \ |    *
    *    ---    ---    ---   ---  -    -    *
    *                                       *
    * * * * * * * * * * * * * * * * * * * * * 
    """;
Console.WriteLine(title_string + "\n");

while (true)
{
    Console.Write($"Please enter your user_name: ");
    string user_input = Console.ReadLine();
    Console.Write($"Please enter your password: ");
    string user_pass = Console.ReadLine();
    if (user_input == user_name && user_pass == password)
    {
        Console.WriteLine($"\nCredentials accepted. Welcome back {user_name}!");
        break;
    }
    else if (user_input == user_name)
    {
        Console.WriteLine("\nError, that password does not seem to be associated with this account. Please try again.\n");
    }
    else 
    {
        Console.WriteLine("\nIncorrect login details. Please try again.\n");
    }
}
