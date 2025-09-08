// Named Arguments - Use out-of - order named calls.

string output = AddStrings(string2: "I'm in the middle", string3: "I'm last", string1: "I'm first");

Console.WriteLine(output);


// Local functions
string AddStrings(string string1, string string2, string string3) => string1 + ", " + string2 + ", " + string3;
