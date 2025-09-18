using System.Text;

int[] numbers = [1, 9, 2, 8, 3, 7, 4, 6, 5];

// Write a method that will take an int[] as input and produce an IEnumerable<int> (it could be a list or array
// if you want) that meets all three of the conditions above using only procedural code— if statements, switches,
// and loops. Hint: the static Array.Sort method might be a useful tool here.

Console.WriteLine("Original: " + ArrayToString(numbers));

int newLength = 0;
foreach (int number in numbers)
{
    if (number % 2 == 0) newLength++;
}

int[] result = new int[newLength];
int pos = 0;
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        result[pos] = number;
        pos++;
    }
}

Array.Sort(result); // känns som fusk...

for (int i = 0; i < result.Length; i++)
{
    result[i] = result[i] * 2;
}

Console.WriteLine("With Loops: " + ArrayToString(result));


//  Write a method that will take an int[] as input and produce an IEnumerable<int> that meets the three above
//   conditions using a keyword-based query expression (from x, where x, select x, etc.).

IEnumerable<int> result2 = from o in numbers
                           where o % 2 == 0
                           orderby o
                           select o * 2;

Console.WriteLine("With Keyword Syntax: " + ArrayToString(result2));


//    - Write a method that will take an int[] as input and produce an IEnumerable<int> that meets the three above
//      conditions using a method-call-based query expression. (x.Select(n => n + 1), x.Where(n => n < 0), etc.)

IEnumerable<int> result3 = numbers.Where(o => o % 2 == 0).OrderBy(o => o).Select(o => o * 2);

Console.WriteLine("With Method Syntax: " + ArrayToString(result2));



// Local functions
string ArrayToString(IEnumerable<int> numbers)
{
    StringBuilder builder = new StringBuilder();
    foreach(int number in numbers)
    {
        builder.Append(number + " ");
    }

    return builder.ToString();  
}

