//  Predicate Filter - Filter list with delegate.

List<int> numbers = [1, 77, 25, 12, 8, 3, 6, 44];
Predicate<int> pred = MyFilter;


// Original values
foreach (int number in numbers)
{
    Console.Write(number + " ");
}

Console.WriteLine();
Console.WriteLine("Filtering away everything below 10");

numbers = Filter(numbers, pred);


// Filtered values
foreach (int number in numbers)
{
    Console.Write(number + " ");
}
Console.WriteLine();



// Local Functions
List<int> Filter(List<int> list, Predicate<int> pred)
{
    List<int> result = new List<int>();

    foreach (int i in list)
    {
        if(pred(i)) result.Add(i);
    }

    return result;
}


bool MyFilter(int i)
{
    return i > 10;
}
