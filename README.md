# The C# Player's Guide - Part 3: Advanced Topics

## Chapter 33: Managing Larger Programs

### From The Book
- [x] Project 1 - The Feud
  - Create a Sheep class in the IField namespace (fully qualified name of IField.Sheep).
  - Create a Pig class in the IField namespace (fully qualified name of IField.Pig).
  - Create a Cow class in the McDroid namespace (fully qualified name of McDroid.Cow).
  - Create a Pig class in the McDroid namespace (fully qualified name of McDroid.Pig).
  - For your main method, add using directives for both IField and McDroid namespaces. Make new
instances of all four classes. There are no conflicts with Sheep and Cow, so make sure you can create
new instances of those with new Sheep() and new Cow(). Resolve the conflicting Pig classes with
either an alias or fully qualified names.

- [x] Project 2 - Dueling Traditions
  - Do the following with one of the larger programs you have created in another challenge.
    - Give your program a traditional Program and Main method instead of top-level statements.
    - Place every type in a namespace.
    - Place each type in its own file. (Small types like enumerations or records can be an exception.)

 
## Chapter 34: Methods Revisited

### From The Book
- [x] Project 1 - Safer Number Crunching
  - Create a program that asks the user for an int value. Use the static int.TryParse(string s,
out int result) method to parse the number. Loop until they enter a valid value.
  - Extend the program to do the same for both double and bool.

- [x] Project 2 - Better Random
  - Random.NextDouble() only returns values between 0 and 1, and they often need to be able to
produce random double values between 0 and another number, such as 0 to 10.
  - They need to randomly choose from one of several strings, such as "up", "down", "left", and
"right", with each having an equal probability of being chosen.
  - They need to do a coin toss, randomly picking a bool, and usually want it to be a fair coin toss (50%
heads and 50% tails) but occasionally want unequal probabilities. For example, a 75% chance of true
and a 25% chance of false.
  - Objectives:
    - Create a new static class to add extension methods for Random.
    - As described above, add a NextDouble extension method that gives a maximum value for a
randomly generated double.
    - Add a NextString extension method for Random that allows you to pass in any number of string
values (using params) and randomly pick one of them.
    - Add a CoinFlip method that randomly picks a bool value. It should have an optional parameter
that indicates the frequency of heads coming up, which should default to 0.5, or 50% of the time.


### From ChatGPT
- [x] Project 3 - Optional Greeting
  - Default param "Hello".

- [x] Project 4 - Named Arguments
  - Use out-of-order named calls.

- [x] Project 5 - Params Total
  - Sum an array of values.

- [x] Project 6 - ref Swap
  - Use ref to swap two variables.

- [x] Project 7 - Extension Method
  - Add .ToLeet() to string.


## Chapter 35: Error Handling

### From The Book
- [x] Project 1 - Exepti's Game
  - Cookie Exception is played by gathering nine chocolate chip cookies and one oatmeal raisin cookie. The
cookies are mixed and put in a dark room with two players who can’t see the cookies. Each player takes
a turn picking a cookie randomly and shoving it in their mouth without seeing whether it is a delicious
chocolate chip cookie or an awful oatmeal raisin cookie. If they pick wrong and eat the oatmeal raisin
cookie, they lose. If their opponent eats the oatmeal raisin cookie, then they win.
  - Objectives:
    - The game will pick a random number between 0 and 9 (inclusive) to represent the oatmeal raisin
cookie.
    - The game will allow players to take turns picking numbers between 0 and 9.
    - If a player repeats a number that has been already used, the program should make them select
another. Hint: If you use a List<int> to store previously chosen numbers, you can use its
Contains method to see if a number has been used before.
    - If the number matches the one the game picked initially, an exception should be thrown, terminating
the program. Run the program at least once like this to see it crash.
    - Put in a try/catch block to handle the exception and display the results.


## Chapter 36: Delegates

### From The Book
- [x] Project 1 - The Sieve
  - Create a Sieve class with a public bool IsGood(int number) method. This class needs a
constructor with a delegate parameter that can be invoked later within the IsGood method. Hint:
You can make your own delegate type or use Func<int, bool>.
  - Define methods with an int parameter and a bool return type for the following: (1) returns true
for even numbers, (2) returns true for positive numbers, and (3) returns true for multiples of 10.
  - Create a program that asks the user to pick one of those three filters, constructs a new Sieve
instance by passing in one of those methods as a parameter, and then ask the user to enter numbers
repeatedly, displaying whether the number is good or bad depending on the filter in use.

### From ChatGPT
- [x] Project 2 - Math Delegate
  - Pass function to compute.

- [x] Project 3 - Multicast Delegate
  - Chain multiple methods.

- [x] Project 4 - Predicate Filter
  - Filter list with delegate.


## Chapter 37: Events

### From The Book
- [x] Project 1 - Charberry Trees
  - The Island of Eventia survives by harvesting and eating the fruit of the native charberry trees. Harvesting
charberry fruit requires three people and an afternoon, but two is enough to feed a family for a week.
Charberry trees fruit randomly, requiring somebody to frequently check in on the plants to notice one
has fruited. Eventia will give you the Medallion of Events if you can help them with two things: (1)
automatically notify people as soon as a tree ripens and (2) automatically harvest the fruit. Their tree
looks like this:
    ```
    CharberryTree tree = new CharberryTree();
    
    while (true)
        tree.MaybeGrow();
    
    public class CharberryTree
    {
        private Random _random = new Random();
        public bool Ripe { get; set; }
    
        public void MaybeGrow()
        {
            // Only a tiny chance of ripening each time, but we try a lot!
            if (_random.NextDouble() < 0.00000001 && !Ripe)
            {
                Ripe = true;
            }
        }
    }
    ```
  - Objectives:
    - Make a new project that includes the above code.
    - Add a Ripened event to the CharberryTree class that is raised when the tree ripens.
    - Make a Notifier class that knows about the tree (Hint: perhaps pass it in as a constructor
parameter) and subscribes to its Ripened event. Attach a handler that displays something like “A
charberry fruit has ripened!” to the console window.
    - Make a Harvester class that knows about the tree (Hint: like the notifier, this could be passed as
a constructor parameter) and subscribes to its Ripened event. Attach a handler that sets the tree’s
Ripe property back to false.
    - Update your main method to create a tree, notifier, and harvester, and get them to work together
to grow, notify, and harvest forever.

### From ChatGPT
- [x] Project 2 - Event Firing
  - Simulate button click.

- [x] Project 3 - Alarm Clock
  - Fire event on timeout.

- [x] Project 4 - Custom EventArgs
  - Send extra data with event.


## Chapter 38: Lambdas

### From The Book
- [x] Project 1 - The Lambda Sieve
  - Modify your The Sieve program from Chapter 36 to use lambda expressions for the constructor instead
of named methods for each of the three filters.


## Chapter 39: Files

### From The Book
- [x] Project 1 - The Long Game
  - When the program starts, ask the user to enter their name.
  - By default, the player starts with a score of 0.
  - Add 1 point to their score for every keypress they make.
  - Display the player’s updated score after each keypress.
  - When the player presses the Enter key, end the game. Hint: the following code reads a keypress and
checks whether it was the Enter key: Console.ReadKey().Key == ConsoleKey.Enter
  - When the player presses Enter, save their score in a file. Hint: Consider saving this to a file named
[username].txt. For this challenge, you can assume the user doesn’t enter a name that would produce
an illegal file name (such as *).
  - When a user enters a name at the start, if they already have a previously saved score, start with that
score instead.

### From chatGPT
- [x] Project 2
  - Write Notes – Save text to a file.
  - Read File – Load and display contents.
  - Word Counter – Count words in file.
  - File Search – Find a word in a file.
  - Directory Scanner – List all files in folder.

 
## Chapter 40: Pattern Matching

### From The Book
- [x] Project 1 - The Potion Masters of Pattren
  - Potions are mixed by adding one ingredient at a time until they produce a valuable potion type. Build potions according to the rules below:
    - All potions start as water.
    - Adding stardust to water turns it into an elixir.
    - Adding snake venom to an elixir turns it into a poison potion.
    - Adding dragon breath to an elixir turns it into a flying potion.
    - Adding shadow glass to an elixir turns it into an invisibility potion.
    - Adding an eyeshine gem to an elixir turns it into a night sight potion.
    - Adding shadow glass to a night sight potion turns it into a cloudy brew.
    - Adding an eyeshine gem to an invisibility potion turns it into a cloudy brew.
    - Adding stardust to a cloudy brew turns it into a wraith potion.
    - Anything else results in a ruined potion.
  - Objectives:
    - Create enumerations for the potion and ingredient types.
    - Tell the user what type of potion they currently have and what ingredient choices are available.
    - Allow them to enter an ingredient choice. Use a pattern to turn the user’s response into an
ingredient.
    - Change the current potion type according to the rules above using a pattern.
    - Allow them to choose whether to complete the potion or continue before adding an ingredient. If
the user decides to complete the potion, end the program.
    - When the user creates a ruined potion, tell them and start over with water.


### From ChatGPT
- [x] Project 2 - Type Check
  - Match on object types.
  
- [x] Project 3 - Guard Pattern
  - Match with conditions.


## Chapter 41: Operator Overloading

### From The Book
- [x] Project 1 - Navigating Operand City
  - The City of Operand is a carefully planned city, organized into city blocks, lined up north to south and
east to west. Blocks are referred to by their coordinates in the city, as we saw in the Cavern of Objects.
The inhabitants of the town use the following three types as they work with the city’s blocks:
    ```
    public record BlockCoordinate(int Row, int Column);
    public record BlockOffset(int RowOffset, int ColumnOffset);
    public enum Direction { North, East, South, West }
    ```
  - BlockCoordinate refers to a specific block’s location, BlockOffset is for relative distances between
blocks, and Direction specifies directions. As we saw with the Cavern of Objects, rows start at 0 at the
north end of the city and get bigger as you go south, while columns start at 0 on the west end of the city
and get bigger as you go east.
  - Make it easy to add a BlockCoordinate with a Direction and also with a BlockOffset to get new BlockCoordinates. Add operators to
BlockCoordinate to achieve this.
  - Objectives:
    - Use the code above as a starting point.
    - Add an addition (+) operator to BlockCoordinate that takes a BlockCoordinate and a
BlockOffset as arguments and produces a new BlockCoordinate that refers to the one you
would arrive at by starting at the original coordinate and moving by the offset. That is, if we started
at (4, 3) and had an offset of (2, 0), we should end up at (6, 3).
    - Add another addition (+) operator to BlockCoordinate that takes a BlockCoordinate and a
Direction as arguments and produces a new BlockCoordinate that is a block in the direction
indicated. If we started at (4, 3) and went east, we should end up at (4, 4).
    - Write code to ensure that both operators work correctly.

- [x] Project 2 - Indexing Operand City
  - Create the ability to index a BlockCoordinate by a number: block[0] for the block’s row and block[1] for the block’s column. Add a get-only indexer to the BlockCoordinate class.
  - Objectives:
    - Add a get-only indexer to BlockCoordinate to access items by an index: index 0 is the row, and
index 1 is the column.

- [x] Project 3 - Converting Directions to Offsets
  - It would be convenient to convert a direction to a BlockOffset. For example, the direction north would become an offset of (-1, 0). 
  - Objectives:
    - Add a custom conversion to BlockOffset that converts from Direction to BlockOffset.


## Chapter 42: Query Expressions (LINQ)

### From The Book
- [x] Project 1 - The Three Lenses
  - Build a solution to a simple problem three times over. Lennik gives you the following array of 
 positive numbers: [1, 9, 2, 8, 3, 7, 4, 6, 5]. He asks you to make a new collection from this
data where:
    - All the odd numbers are filtered out, and only the even should be considered.
    - The numbers are in order.
    - The numbers are doubled.
  - For example, with the array above, the odd/even filter should result in 2, 8, 4, 6. The ordering step should
result in 2, 4, 6, 8. The doubling step should result in 4, 8, 12, 16 as the final answer.
  - Objectives:
    - Write a method that will take an int[] as input and produce an IEnumerable<int> (it could be
a list or array if you want) that meets all three of the conditions above using only procedural code—
if statements, switches, and loops. Hint: the static Array.Sort method might be a useful tool
here.
    - Write a method that will take an int[] as input and produce an IEnumerable<int> that meets
the three above conditions using a keyword-based query expression (from x, where x, select x,
etc.).
    - Write a method that will take an int[] as input and produce an IEnumerable<int> that meets
the three above conditions using a method-call-based query expression. (x.Select(n => n + 1),
x.Where(n => n < 0), etc.)
    - Run all three methods and display the results to ensure they all produce good answers.


### From ChatGPT

- [x] Project 2 - Filter Names
  - Show only names that start with 'A' or 'a'.

- [x] Project 3 - Student Grades
  - Compute average and order.

- [x] Project 4 - Group Products
  - Group by category.
  

## Chapter 43: Threads

### From The Book
- [x] Project 1 - The Repeating Stream
  - Build a program to generate numbers while simultaneously allowing a user to flag repeats.
  - Objectives:
    - Make a RecentNumbers class that holds at least the two most recent numbers.
    - Make a method that loops forever, generating random numbers from 0 to 9 once a second. Hint:
Thread.Sleep can help you wait.
    - Write the numbers to the console window, put the generated numbers in a RecentNumbers object,
and update it as new numbers are generated.
    - Make a thread that runs the above method.
    - Wait for the user to push a key in a second loop (on the main thread or another new thread). When
the user presses a key, check if the last two numbers are the same. If they are, tell the user that they
correctly identified the repeat. If they are not, indicate that they got it wrong.
    - Use lock statements to ensure that only one thread accesses the shared data at a time.

### From ChatGPT
- [x] Project 2 - Basic Thread Start
  - Launch a thread that prints “Working…” 5 times.

- [x] Project 3 - Multi-Printer
  - Launch two threads to print different characters simultaneously.
 
- [x] Project 4 - Thread Join
  - Wait for a worker thread to finish before continuing.

- [x] Project 5 - Race Condition Demo
  - Show how two threads can corrupt a shared counter.

- [ ] Project 6 - Thread-Safe Counter
  - Fix the above using lock.


Chapter 44: Advanced Threading Tools
    1. Thread Pool Task – Use ThreadPool.QueueUserWorkItem to run a method.
    2. AutoResetEvent Demo – Wait for a thread signal before proceeding.
    3. ManualResetEvent – Start multiple tasks that wait for a single release.
    4. Thread Timing – Use Stopwatch to compare parallel vs serial execution.
    5. Simulated Work Queue – Launch multiple threads pulling from a shared queue.


Chapter 45: Tasks
    1. Simple Task – Create a task that prints after a delay.
    2. Parallel Tasks – Run 3 tasks at once to simulate downloads.
    3. Task Continuation – Chain a second task after the first.
    4. Task.Result – Retrieve a computed value from a Task<int>.
    5. Task WhenAll – Wait for a set of tasks to complete and combine results.

Chapter 46: async and await
    1. Async Message – Create a method that uses await Task.Delay.
    2. Await Result – Download a fake file with simulated delay and print “done”.
    3. UI-Friendly Delay – Add delay in a loop without freezing console.
    4. Async Data Fetcher – Await a method that returns a string after delay.
    5. Multiple Await – Run two awaits in sequence and one in parallel.

Chapter 47: Structs vs Classes (Deep Dive)
    1. Value Copy Test – Show how struct copies differ from reference sharing.
    2. Ref vs Value Performance – Measure impact of passing large struct by value vs ref.
    3. Mutation Demo – Show how modifying one affects the other.
    4. Ref Struct Creation – Create a ref struct and demonstrate its usage limits.
    5. Immutable Structs – Create a fully read-only struct for safety.

Chapter 48: Ref Locals and Ref Returns
    1. Ref Swap – Use ref return to swap elements in an array.
    2. Ref Max Element – Return a reference to the largest value in an array.
    3. Ref Accessor – Return a ref to a private field and modify it externally.
    4. Ref Chain – Use one ref return to feed another ref method.
    5. Span Ref Return – Combine ref return and slicing to locate data.

Chapter 49: Unsafe Code
    1. Pointer Basics – Create and print the address of a pointer.
    2. Pointer Arithmetic – Walk through an array using pointers.
    3. Fixed Keyword – Use fixed to pin an array during pointer access.
    4. Compare Safe vs Unsafe – Time unsafe memory copy vs safe copy.
    5. Dangerous Write – Simulate a memory corruption scenario (with care!).

Chapter 50: Nullable Reference Types
    1. Enable Nullable – Turn on nullable warnings and refactor.
    2. ?. and ?? operators – Use to access and fallback from nulls safely.
    3. Nullable Class Field – Design a class with nullable vs non-nullable fields.
    4. Null Safety Formatter – Create a method that returns fallback if null.
    5. Assert Not Null – Use ! to assert a non-null value and explain risks.

Chapter 51: Attributes
    1. Create Attribute – Define [GameHint] and apply it to a class.
    2. Attribute Reader – Use reflection to read custom attributes.
    3. Mark For Save – Tag properties with [Saveable] and serialize only those.
    4. Multiple Attributes – Create two attributes and apply both to one class.
    5. Attribute Validator – Enforce rules using attribute-based logic.