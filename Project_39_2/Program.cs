string? text;
string filename = "textfile.txt";

Console.Write("Enter a line of text: ");
text = Console.ReadLine();


// Write Notes – Save text to a file.
File.WriteAllText(filename, text);


// Read File – Load and display contents.
Console.WriteLine("You wrote: " + File.ReadAllText(filename));


// Word Counter – Count words in file.
string fileContent  = File.ReadAllText(filename);
string[] words = fileContent.Split(' ');
Console.WriteLine("You wrote " + words.Length + " words.");


// File Search – Find a word in a file.
if (fileContent.Contains("Hello") || fileContent.Contains("hello"))
{
    Console.WriteLine("The file does contain the word \"Hello\" or \"hello\"");
}
else
{
    Console.WriteLine("The file does NOT contain the word \"Hello\" or \"hello\"");
}


// Directory Scanner – List all files in folder.
IEnumerable<string> files = Directory.EnumerateFiles(".");
Console.WriteLine("The current directory contains the following files:");

foreach (string file in files)
{
    Console.WriteLine(Path.GetFileName(file));
}
