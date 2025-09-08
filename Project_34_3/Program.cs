// Optional Greeting - Default param "Hello".

Console.WriteLine(Greeting("I don't use default greetings!"));
Console.WriteLine(Greeting());



// Local functions
string Greeting(string greeting = "Hello") => greeting;

