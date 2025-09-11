// Multicast Delegate - Chain multiple methods.

Action writeStuff = SayHello;
writeStuff += SayGodmorning;
writeStuff += SayGoodbye;


writeStuff();



// Local Functions
void SayHello() => Console.WriteLine("Hello!");
void SayGodmorning() => Console.WriteLine("Good Morning!");
void SayGoodbye() => Console.WriteLine("Goodbye!");






