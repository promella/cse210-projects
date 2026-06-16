while (true)
{
    Console.WriteLine();
    Console.WriteLine("Eternal Quest");
    Console.WriteLine($"Score: {manager.Score}");
    Console.WriteLine();
    Console.WriteLine("1. Create Goal");
    Console.WriteLine("2. List Goals");
    Console.WriteLine("3. Record Event");
    Console.WriteLine("4. Save Goals");
    Console.WriteLine("5. Load Goals");
    Console.WriteLine("6. Quit");

    Console.Write("Select: ");
    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            CreateGoal();
            break;

        case "2":
            manager.DisplayGoals();
            break;

        case "3":
            RecordGoal();
            break;

        case "4":
            manager.SaveGoals("goals.txt");
            break;

        case "5":
            manager.LoadGoals("goals.txt");
            break;

        case "6":
            return;
    }
}