// Extension Method - Add.ToLeet() to string.
using System.Text;

Console.Write("Enter a sentence to translate: ");
string input = Console.ReadLine();

Console.WriteLine(input.ToLeet());


// Types
public static class StringExtensions
{
    public static string ToLeet(this string text)
    {
        Dictionary<char, string> leet = new Dictionary<char, string>()
        {
            { 'a', "4" },
            { 'b', "8" },
            { 'c', "([" },
            { 'd', "I7" },
            { 'e', "&" },
            { 'f', "ph" },
            { 'g', "6" },
            { 'h', "#" },
            { 'i', "1" },
            { 'j', "]" },
            { 'k', "|<" },
            { 'l', "1" },
            { 'm', "11" },
            { 'n', "^" },
            { 'o', "0" },
            { 'p', "|*" },
            { 'q', "9" },
            { 'r', "|2" },
            { 's', "5" },
            { 't', "7" },
            { 'u', "V" },
            { 'v', "\\/" },
            { 'w', "vv" },
            { 'x', "Ecks" },
            { 'y', "¥" },
            { 'z', "2" },
            { ' ', " " }
        };

        text = text.ToLower();
        StringBuilder builder = new StringBuilder();
        
        foreach (char c in text)
        {
            builder.Append(leet[c]);
        }

        return builder.ToString();
    }
}
