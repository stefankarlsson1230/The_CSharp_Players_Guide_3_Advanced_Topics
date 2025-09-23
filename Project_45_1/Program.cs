
Console.WriteLine($"{3} + {4} = {Add(3,4)}");
Console.WriteLine($"{3.67} + {4.98} = {Add(3.67, 4.98)}");
Console.WriteLine($"{"Good"} + {" Morning"} = {Add("Good", " Morning")}");
Console.WriteLine($"{DateTime.Now.ToShortTimeString()} + {new TimeSpan(0, 10, 0)} = {Add(DateTime.Now, new TimeSpan(0,10,0))}");

// --------------------------------------
dynamic Add(dynamic a, dynamic b) => a + b;
