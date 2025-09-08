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
    1. Optional Greeting – Default param "Hello".\n2. Named Arguments – Use out-of-order named calls.\n3. params Total – Sum an array of values.\n4. ref Swap – Use ref to swap two variables.\n5. Extension Method – Add .ToLeet() to string.

Chapter 35: Error Handling
    1. Safe Divide – Handle division by zero.\n2. TryParse Input – Validate int safely.\n3. Custom Exception – Define and throw custom error.\n4. Retry on Error – Ask again until success.\n5. Exception Logger – Write caught exception to file.

Chapter 36: Delegates
    1. Math Delegate – Pass function to compute.\n2. Multicast Delegate – Chain multiple methods.\n3. Anonymous Function – Use inline method.\n4. Predicate Filter – Filter list with delegate.\n5. Strategy Pattern – Use delegate to choose action.

Chapter 37: Events
    1. Event Firing – Simulate button click.\n2. Alarm Clock – Fire event on timeout.\n3. Game Health Event – Trigger on zero HP.\n4. Custom EventArgs – Send extra data with event.\n5. Multi Subscriber – Multiple methods respond to one event.

Chapter 38: Lambdas
    1. Multiply – x => x * 2\n2. Filter List – List.FindAll()\n3. Sort by Length – Use lambda to sort\n4. Projection – Transform objects with Select()\n5. Counter Closure – Return lambda that increments internal count.

Chapter 39: Files
    1. Write Notes – Save text to a file.\n2. Read File – Load and display contents.\n3. Word Counter – Count words in file.\n4. File Search – Find a word in a file.\n5. Directory Scanner – List all files in folder.

Chapter 40: Pattern Matching
    1. Type Check – Match on object types.\n2. Guard Pattern – Match with conditions.\n3. Property Match – Match on property values.\n4. Shape Matcher – Match multiple shapes and respond.\n5. Pattern Router – Use pattern match for command routing.

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