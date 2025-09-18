// Filter Names - Show only names that start with 'A' or 'a'.

using System.Text;

List<string> names1 = new List<string>() { "William", "Abigail", "James", "Amelia", "Thomas", "Emily", "Andrew", "Olivia", "Benjamin", "Adam", "Charlotte", "Hannah",
    "Daniel", "Lucas", "Katherine", "Alice", "Samuel", "George", "Matthew", "Isaac" };

List<string> names2 = new List<string>() { "William", "Abigail", "James", "Amelia", "Thomas", "Emily", "Andrew", "Olivia", "Benjamin", "Adam", "Charlotte", "Hannah",
    "Daniel", "Lucas", "Katherine", "Alice", "Samuel", "George", "Matthew", "Isaac" };

Console.WriteLine("All names: " + ListToString(names1));


// Keyword syntax
IEnumerable<string> result1 = from n in names1
                              where Char.ToLower(n[0]) == 'a' 
                              select n;

Console.WriteLine("Keyword syntax: " + ListToString(result1));


// Method syntax
List<string> result2 = names2.Where(n => Char.ToLower(n[0]) == 'a').ToList();
Console.WriteLine("Method syntax: " + ListToString(result2));





// Local functions

string ListToString(IEnumerable<string> names)
{
    StringBuilder builder = new StringBuilder(" ");

    foreach (string name in names) builder.Append(name + " ");
    builder.AppendLine();

    return builder.ToString();
}