namespace TwitterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice;
            do
            {
                Console.WriteLine("Main Menu");
                string[] menus = new string[] { "1. View all tweets", "2. Post tweets", "3. Exit" };
                for (int i = 0; i <= menus.Length - 1; i++)
                {
                    Console.WriteLine(menus[i]);
                }
                choice = Console.ReadLine();
                Console.WriteLine("You enter {0}", choice);
            }
            while (choice != "3");
            Environment.Exit(0);
        }
        // {
        //     string[] tweets = new string[2];
        //     for (int i = 0; i < tweets.Length; i++)
        //     {
        //         Console.Write("Enter tweet {0}", i);
        //         tweets[i] = Console.ReadLine();
        //         if (tweets[i].Length >= 5)
        //             Console.WriteLine("your tweet is too long, please try again");
        //             tweets[i] = Console.ReadLine();

        //     }
        //     Console.WriteLine("User input:");
        //     foreach (var tweet in tweets)
        //     {
        //         Console.WriteLine(tweet);
        //     }

        // }
    }
}