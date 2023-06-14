#nullable disable

// Start
Console.Clear();
Console.WriteLine("Dice Roll Simulator Menu");
Random rnd = new Random();

// Loop
while (true)
{
    Console.Write(
        "1. Roll Dice Once\n" +
        "2. Roll Dice 5 Times\n" +
        "3. Roll Dice \"n\" Times\n" +
        "4. Roll Dice until Snake Eyes\n" +
        "5. Exit\n" +
        "Select an option (1-5): "
    );

    string option = Console.ReadLine();
    Console.WriteLine();

    if (option == "1")
    {
        int d1 = rnd.Next(1, 7);
        int d2 = rnd.Next(1, 7);
        int sum = d1 + d2;

        Console.WriteLine($"{d1},{d2} (sum: {sum})");
    }
    else if (option == "2")
    {
        for (int n = 0; n < 5; n++)
        {
            int d1 = rnd.Next(1, 7);
            int d2 = rnd.Next(1, 7);
            int sum = d1 + d2;

            Console.WriteLine($"{d1},{d2} (sum: {sum})");
        }
    }
    else if (option == "3")
    {
        Console.Write("How many rolls would you like? ");
        int rollNum = Convert.ToInt32(Console.ReadLine());

        for (int n = 0; n < rollNum; n++)
        {
            int d1 = rnd.Next(1, 7);
            int d2 = rnd.Next(1, 7);
            int sum = d1 + d2;

            Console.WriteLine($"{d1},{d2} (sum: {sum})");
        }
    }
    else if (option == "4")
    {
        int sum = 3;
        int rollCount = 0;

        while (sum > 2)
        {
            int d1 = rnd.Next(1, 7);
            int d2 = rnd.Next(1, 7);
            sum = d1 + d2;
            rollCount++;

            Console.WriteLine($"{d1},{d2} (sum: {sum})");
        }

        Console.WriteLine($"SNAKE EYES! It took {rollCount} rolls to get snake eyes.");
    }
    else if (option == "5")
    {
        break;
    }
    else
    {
        Console.WriteLine("Not a valid option");
    }

    Console.WriteLine();
}