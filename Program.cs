// See https://aka.ms/new-console-template for more information
using LinqFaroShuffle;

Console.WriteLine("Work with Language-Integrated Query (LINQ)");

// Try to remove all ToArray method used in the example and compare time
var startingDeck = (
    from s in Suits().LogQuery("Suits Generation")
    from r in Ranks().LogQuery("Ranks Generation")
    select new { Suit = s, Rank = r }
)
    .LogQuery("Starting Deck")
    .ToArray();

// Or (both are the same)
// var startingDeck = Suits().SelectMany(suit => Ranks().Select(rank => new { Suit = suit, Rank = rank }));

foreach (var card in startingDeck)
{
    Console.WriteLine(card);
}

var times = 0;
var shuffle = startingDeck;

do
{
    // Perfect Faro out shuffle
    // shuffle = shuffle
    //     .Skip(26)
    //     .LogQuery("Bottom Half")
    //     .InterleaveSequenceWith(shuffle.Take(26).LogQuery("Top Half"))
    //     .LogQuery("Shuffle")
    //     .ToArray();

    // Faro in shuffle
    // 52 cards in a deck, so 52 / 2 = 26
    shuffle = shuffle
        .Take(26)
        .LogQuery("Top Half")
        .InterleaveSequenceWith(shuffle.Skip(26).LogQuery("Bottom Half"))
        .LogQuery("Shuffle")
        .ToArray();

    foreach (var card in shuffle)
    {
        Console.WriteLine(card);
    }

    Console.WriteLine();
    times++;
} while (!startingDeck.SequenceEquals(shuffle));

Console.WriteLine(times);

static IEnumerable<string> Suits()
{
    // yield statement https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/yield
    yield return "clubs";
    yield return "diamonds";
    yield return "hearts";
    yield return "spades";
}

static IEnumerable<string> Ranks()
{
    yield return "two";
    yield return "three";
    yield return "four";
    yield return "five";
    yield return "six";
    yield return "seven";
    yield return "eight";
    yield return "nine";
    yield return "ten";
    yield return "jack";
    yield return "queen";
    yield return "king";
    yield return "ace";
}
