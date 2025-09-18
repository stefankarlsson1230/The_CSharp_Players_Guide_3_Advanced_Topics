// Group Products - Group by category.

// 20 random items from chatGPT
var items = new List<Item>
{
    new Item("Laptop", "Electronics"),
    new Item("Sofa", "Furniture"),
    new Item("T-Shirt", "Clothing"),
    new Item("Basketball", "Sports"),
    new Item("Headphones", "Electronics"),
    new Item("Dining Table", "Furniture"),
    new Item("Sneakers", "Clothing"),
    new Item("Novel", "Books"),
    new Item("Monitor", "Electronics"),
    new Item("Jacket", "Clothing"),
    new Item("Dumbbells", "Sports"),
    new Item("Bookshelf", "Furniture"),
    new Item("Keyboard", "Electronics"),
    new Item("Soccer Ball", "Sports"),
    new Item("Dress", "Clothing"),
    new Item("Armchair", "Furniture"),
    new Item("Tablet", "Electronics"),
    new Item("Cookbook", "Books"),
    new Item("Tennis Racket", "Sports"),
    new Item("Comics", "Books"),
};

// Listing all items
Console.WriteLine("All items\n");
foreach(Item item in items)
{
    Console.WriteLine($"Item: {item.name, -20}  Group: {item.group,-20}");
}
Console.WriteLine();


// Groupng items and showing the groups
IEnumerable<IGrouping<string, Item>> groups = items.GroupBy(i => i.group);

foreach(IGrouping<string, Item> group in groups)
{
    Console.WriteLine($"Group: {group.Key}");

    foreach(Item item in group)
    {
        Console.Write(item.name + " ");
    }
    Console.WriteLine("\n");
}




// Types
public record Item(string name, string group);
