using System.Text;

Console.Write("Enter a short word: ");
string word = Console.ReadLine().ToLower();

DateTime start = DateTime.Now;
int result = await RandomlyRecreateAsync(word);
DateTime end = DateTime.Now;

Console.WriteLine($"It took {(end - start).TotalSeconds:0} seconds and {result} tries to recreate the word \"{word}\"");



// --------------------------------------

Task<int> RandomlyRecreateAsync(string word)
{
    return Task.Run(() =>
    {
        return RandomlyRecreate(word);
    });
}


// It is okay to assume all words only use lowercase letters
int RandomlyRecreate(string word)
{
    Random random = new Random();
    int length = word.Length;
    StringBuilder newWord = new StringBuilder();
    int count = 0;

    do
    {
        newWord.Clear();

        for (int i = 0; i < length; i++)
        {
            newWord.Append((char)('a' + random.Next(26)));
        }
        
        count++;
    }
    while (newWord.ToString() != word);

    return count;
}

