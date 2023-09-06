// WriteColor("Working with LINQ", ConsoleColor.Red, true);

// int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

// WorkWithNumbers();
// WorkWithNames();
// WorkWithJoining();

static void WorkWithNumbers()
{
    var evenNumbers = DataSources.Numbers.Where(number => int.IsEvenInteger(number));
    var oddNumbers = DataSources.Numbers.Where(number => int.IsOddInteger(number));

    WriteColor("Numbers list:", ConsoleColor.Blue, true);
    foreach (var number in DataSources.Numbers)
    {
        Console.Write("{0,2} ", number);
    }

    Console.WriteLine();
    WriteColor("Odd numbers only:", ConsoleColor.Blue, true);
    foreach (var number in oddNumbers)
    {
        Console.Write("{0,2} ", number);
    }

    Console.WriteLine();
    WriteColor("Even numbers only:", ConsoleColor.Blue, true);
    foreach (var number in evenNumbers)
    {
        Console.Write("{0,2} ", number);
    }

    Console.WriteLine();
}

static void WorkWithNames()
{
    var startsWithA = DataSources.Names.Where(name => name.StartsWith("A"));
    var dearAdded = DataSources.Names.Select(name => $"Dear {name}");
    WriteColor("Names list:", ConsoleColor.Blue, true);
    WriteColorful(string.Join(", ", DataSources.Names));

    WriteColor("Names that starts with A:", ConsoleColor.Blue, true);
    WriteColorful(string.Join(", ", startsWithA));

    WriteColor("Names with Dear added:", ConsoleColor.Blue, true);
    WriteColorful(string.Join(", ", dearAdded), ", ", ", ");
}

static void WorkWithJoining()
{
    var joining =
        from order in DataSources.Orders
        from customer in DataSources.Customers
        where order.CustomerId == customer.Id
        select new { order.Id, order.OrderDate, order.TotalPrice, customer.Name };

    Console.WriteLine(
        System.Text.Json.JsonSerializer.Serialize(
            joining,
            new System.Text.Json.JsonSerializerOptions { WriteIndented = true }
        )
    );
}

static void WriteColor(string text, ConsoleColor color = ConsoleColor.White, bool newLine = false)
{
    Console.ForegroundColor = color;
    Console.Write(text);
    Console.ResetColor();
    if (newLine)
    {
        Console.Write(Environment.NewLine);
    }
}

static void WriteColorful(string text, string separator = " ", string concatString = " ")
{
    string[] words = text.Split(separator);

    for (int i = 0; i < words.Length; i++)
    {
        ConsoleColor color = (ConsoleColor)(Random.Shared.Next(8, 16)); // use different colors for each word
        Console.ForegroundColor = color;
        Console.Write(words[i] + concatString);
    }

    Console.ResetColor();
    Console.WriteLine();
}
