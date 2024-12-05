// This is a comment to my code

// Rakendus küsib kasutajal küsida tema nime
// Rakendus tervitab kasutajat nimepidi
Console.WriteLine("Enter your name:"); //Output
// string - sõne
string userName = Console.ReadLine(); //Input

Console.WriteLine("Hello" + ", " + userName + "!");
// string interpolation

Console.WriteLine($"Hello, {userName}!");