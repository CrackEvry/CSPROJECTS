// Number Guesser - paste this into Program.cs (C# 10+ top-level program)

Console.WriteLine("=== Number Guesser ===");
var rng = Random.Shared;

while (true)
{
    int secret = rng.Next(1, 101); // 1..100
    int attempts = 0;
    Console.WriteLine("I picked a number between 1 and 100. Type your guess!");

    while (true)
    {
        Console.Write("Guess (or 'q' to quit): ");
        string? input = Console.ReadLine();

        if (string.Equals(input, "q", StringComparison.OrdinalIgnoreCase))
            return;

        if (!int.TryParse(input, out int guess) || guess < 1 || guess > 100)
        {
            Console.WriteLine("Please enter a whole number 1–100.");
            continue;
        }

        attempts++;
        if (guess < secret) Console.WriteLine("Higher ↑");
        else if (guess > secret) Console.WriteLine("Lower ↓");
        else
        {
            Console.WriteLine($"✅ Correct! It was {secret}. Attempts: {attempts}");
            break;
        }
    }

    Console.Write("Play again? (y/n): ");
    var again = Console.ReadLine();
    if (!string.Equals(again, "y", StringComparison.OrdinalIgnoreCase))
        break;
}

Console.WriteLine("Bye!");
