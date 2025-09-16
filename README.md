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


Chapter 41: Operator Overloading
    1. Vector + Vector – Overload + for struct.\n2. Card Comparison – Add > and <.\n3. Inventory Indexer – Access item via index.\n4. Unit Conversion – Implicit conversion between units.\n5. Complex Math – Add math operators to complex number class.


Chapter 42: Query Expressions (LINQ)
    1. Filter Names – Show only names that start with 'A'.\n2. Student Grades – Compute average and order.\n3. Group Products – Group by category.\n4. Join Data – Merge user and order list by ID.\n5. LINQ Report – Transform a full list into a readable output.


Chapter 43: Threads
    1. Basic Thread Start – Launch a thread that prints “Working…” 5 times.
    2. Multi-Printer – Launch two threads to print different characters simultaneously.
    3. Thread Join – Wait for a worker thread to finish before continuing.
    4. Race Condition Demo – Show how two threads can corrupt a shared counter.
    5. Thread-Safe Counter – Fix the above using lock.

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