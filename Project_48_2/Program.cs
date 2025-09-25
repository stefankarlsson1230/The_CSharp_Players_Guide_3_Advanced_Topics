using Humanizer;

Console.WriteLine($"When is the feast? {DateTime.UtcNow.AddHours(5).Humanize()}");

