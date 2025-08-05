# The C# Player's Guide - Part 3: Advanced Topics

Chapter 33: Managing Larger Programs
    1. Split Files – Move classes to separate files.
    2. Custom Namespace – Create and use your own.
    3. Reorganize Methods – Move to utility class.
    4. Library Project – Build a reusable library.
    5. Class Library Tester – Build one program that imports another.

Project 2: Dungeon Map Renderer
Topics Covered: Arrays, Loops, Console Color, Enums, Pattern Matching
Overview:
Render a 2D dungeon map in the console using characters and colors. Let the user place walls, rooms, and symbols.
Core Features:
    • 2D char[,] array to represent the map
    • Colorize symbols using ANSI escape codes (\e)
    • Display with Console.SetCursorPosition
    • Use enums for tile types
    • Optional: Save/load to a file
Start After:
    • Chapter 8 (Console 2.0)
    • Chapter 11 (Looping)
    • Chapter 12 (Arrays)
    • Chapter 33 (Managing Larger Programs – optional)
You’ll need:
    • Console cursor manipulation
    • 2D arrays
    • Basic rendering logic


Chapter 34: Methods Revisited
    1. Optional Greeting – Default param "Hello".\n2. Named Arguments – Use out-of-order named calls.\n3. params Total – Sum an array of values.\n4. ref Swap – Use ref to swap two variables.\n5. Extension Method – Add .ToLeet() to string.

Chapter 35: Error Handling
    1. Safe Divide – Handle division by zero.\n2. TryParse Input – Validate int safely.\n3. Custom Exception – Define and throw custom error.\n4. Retry on Error – Ask again until success.\n5. Exception Logger – Write caught exception to file.

Chapter 36: Delegates
    1. Math Delegate – Pass function to compute.\n2. Multicast Delegate – Chain multiple methods.\n3. Anonymous Function – Use inline method.\n4. Predicate Filter – Filter list with delegate.\n5. Strategy Pattern – Use delegate to choose action.

Project 3: Battle Simulator
Topics Covered: Inheritance, Interfaces, Polymorphism, Records, Delegates
Overview:
Create a text-based battle simulator with warriors, mages, and archers each having unique abilities and strategies.
Core Features:
    • Base Fighter class with Attack(), Defend() methods
    • Derived classes override behavior
    • Interface ISpecialMove
    • Use delegate to define and plug in strategies
    • Use records for immutable battle results log
Start After:
    • Chapter 25 (Inheritance)
    • Chapter 26 (Polymorphism)
    • Chapter 27 (Interfaces)
    • Chapter 36 (Delegates)
 You’ll need:
    • Polymorphic behaviors
    • Strategy patterns via delegates
    • Dynamic behavior through interfaces




Chapter 37: Events
    1. Event Firing – Simulate button click.\n2. Alarm Clock – Fire event on timeout.\n3. Game Health Event – Trigger on zero HP.\n4. Custom EventArgs – Send extra data with event.\n5. Multi Subscriber – Multiple methods respond to one event.

Chapter 38: Lambdas
    1. Multiply – x => x * 2\n2. Filter List – List.FindAll()\n3. Sort by Length – Use lambda to sort\n4. Projection – Transform objects with Select()\n5. Counter Closure – Return lambda that increments internal count.

Chapter 39: Files
    1. Write Notes – Save text to a file.\n2. Read File – Load and display contents.\n3. Word Counter – Count words in file.\n4. File Search – Find a word in a file.\n5. Directory Scanner – List all files in folder.


Project 4: Personal Finance Tracker
Topics Covered: File I/O, Static Classes, Records, Tuples, Properties, Exception Handling
Overview:
Track income and expenses, categorize them, generate reports, and save/load to a file.
Core Features:
    • Transaction record with amount, date, category
    • Monthly summaries using GroupBy
    • Command-based interface for adding/removing data
    • Use static utility class for formatting
    • Exception handling for file operations and input
Start After:
    • Chapter 39 (Files)
    • Chapter 35 (Error Handling)
    • Chapter 20 (Properties)
    • Chapter 30 (Generics) – optional for reusable components
You’ll need:
    • Record-based data storage
    • File persistence
    • User input and validation
    • Exception handling for resilience



Chapter 40: Pattern Matching
    1. Type Check – Match on object types.\n2. Guard Pattern – Match with conditions.\n3. Property Match – Match on property values.\n4. Shape Matcher – Match multiple shapes and respond.\n5. Pattern Router – Use pattern match for command routing.

Chapter 41: Operator Overloading
    1. Vector + Vector – Overload + for struct.\n2. Card Comparison – Add > and <.\n3. Inventory Indexer – Access item via index.\n4. Unit Conversion – Implicit conversion between units.\n5. Complex Math – Add math operators to complex number class.


Project 5: RPG Quest Engine
Topics Covered: Inheritance, Interfaces, Events, Delegates, Enums, JSON Serialization
Overview:
Create a simple quest system where players can accept, complete, and chain quests with rewards and branching logic.
Core Features:
    • Quest base class with derived types (Fetch, Kill, Escort)
    • Interface IRewardable
    • Delegate OnQuestComplete for callbacks
    • Enum for quest difficulty
    • Save/load quest state from JSON (simulate persistence)
Start After:
    • Chapter 23 (Design Principles)
    • Chapter 25–27 (OOP: Inheritance, Interfaces)
    • Chapter 36 (Delegates)
    • Optional: Chapter 29 (Records), Chapter 39 (Files)
You’ll need:
    • OOP composition
    • Dynamic behaviors through events and interfaces
    • Record types for results
    • Delegate callbacks for quest completion




Chapter 42: Query Expressions (LINQ)
    1. Filter Names – Show only names that start with 'A'.\n2. Student Grades – Compute average and order.\n3. Group Products – Group by category.\n4. Join Data – Merge user and order list by ID.\n5. LINQ Report – Transform a full list into a readable output.


 Project 6: Inventory Manager with Search
Topics Covered: Classes, Lists, LINQ, Pattern Matching, File I/O
Overview:
Create a program to manage inventory items, with add, remove, search, sort, and filter functionality.
Core Features:
    • Use List<Item> where Item is a class with Name, Type, Value
    • Search by name with LINQ
    • Filter by item type using pattern matching
    • Save/load items to/from a text file
    • Use optional parameters in lambda-based filters
Start After:
    • Chapter 18 (Classes)
    • Chapter 27 (Interfaces)
    • Chapter 32 (Useful Types – especially List<T>)
    • Chapter 42 (LINQ / Query Expressions)
 You’ll need:
    • Collections (like List<T>)
    • File I/O
    • Pattern matching and object filtering with LINQ




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


Project 7: Recipe Recommendation System
Topics Covered: LINQ, Collections, Files, Delegates, Pattern Matching, Records
Overview:
Build an app that recommends recipes based on available ingredients, diet preferences, and calories.
Core Features:
    • Load recipe data from a JSON/text file
    • Filter recipes with LINQ queries
    • Use pattern matching on food types
    • Use delegates for flexible filtering logic
    • Define recipes as record types
Start After:
    • Chapter 32 (Useful Types)
    • Chapter 34 (Methods Revisited – optional/named/default)
    • Chapter 35 (Error Handling)
    • Chapter 42 (LINQ Queries)
You’ll need:
    • LINQ and filtering
    • Delegates for search criteria
    • File reading/writing
    • Optionally: record types and pattern matching




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