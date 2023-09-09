/*
Random Module in C# 
Console.WriteLine("-----------------Example 1------------------------");
Console.WriteLine(
    "This example of the Random.Next() methods\n" +
    "generates the following output.\n");
Console.WriteLine(
    "Create Random objects all with the same seed and " +
    "generate\nsequences of numbers with different " +
    "bounds. Note the effect\nthat the various " +
    "combinations of bounds have on the sequences.");

NoBoundsRandoms(234);

UpperBoundRandoms(234, Int32.MaxValue);
UpperBoundRandoms(234, 2000000000);
UpperBoundRandoms(234, 200000000);

BothBoundsRandoms(234, 0, Int32.MaxValue);
BothBoundsRandoms(234, Int32.MinValue, Int32.MaxValue);
BothBoundsRandoms(234, -2000000000, 2000000000);
BothBoundsRandoms(234, -200000000, 200000000);
BothBoundsRandoms(234, -2000, 2000);

// Generate random numbers with no bounds specified.
void NoBoundsRandoms(int seed)
{
    Console.WriteLine(
        "\nRandom object, seed = {0}, no bounds:", seed);
    Random randObj = new Random(seed);

    // Generate six random integers from 0 to int.MaxValue.
    for (int j = 0; j < 6; j++)
        Console.Write("{0,11} ", randObj.Next());
    Console.WriteLine();
}

// Generate random numbers with an upper bound specified.
void UpperBoundRandoms(int seed, int upper)
{
    Console.WriteLine(
        "\nRandom object, seed = {0}, upper bound = {1}:",
        seed, upper);
    Random randObj = new Random(seed);

    // Generate six random integers from 0 to the upper bound.
    for (int j = 0; j < 6; j++)
        Console.Write("{0,11} ", randObj.Next(upper));
    Console.WriteLine();
}

// Generate random numbers with both bounds specified.
void BothBoundsRandoms(int seed, int lower, int upper)
{
    Console.WriteLine(
        "\nRandom object, seed = {0}, lower = {1}, " +
        "upper = {2}:", seed, lower, upper);
    Random randObj = new Random(seed);

    // Generate six random integers from the lower to
    // upper bounds.
    for (int j = 0; j < 6; j++)
        Console.Write("{0,11} ",
            randObj.Next(lower, upper));
    Console.WriteLine();
}

Console.WriteLine("-----------------Example 2------------------------");

Random rnd = new Random();
string[] malePetNames = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska" };
string[] femalePetNames = { "Maggie", "Penny", "Saya", "Princess",
                            "Abby", "Laila", "Sadie", "Olivia",
                            "Starlight", "Talla" };

// Generate random indexes for pet names.
int mIndex = rnd.Next(malePetNames.Length);
int fIndex = rnd.Next(femalePetNames.Length);

// Display the result.
Console.WriteLine("Suggested pet name of the day: ");
Console.WriteLine("   For a male:     {0}", malePetNames[mIndex]);
Console.WriteLine("   For a female:   {0}", femalePetNames[fIndex]);

// The example displays output similar to the following:
//       Suggested pet name of the day:
//          For a male:     Koani
//          For a female:   Maggie

Console.WriteLine("-----------------Example 3------------------------");
// Generating Random integer for a certain range
// Random rnd = new Random(); use this line or the nest line
Random rnd = new(); // alternative to the previous line(both options are available)

Console.WriteLine("\n20 random integers from -100 to 100:");
for (int ctr = 1; ctr <= 20; ctr++)
{
   Console.Write("{0,6}", rnd.Next(-100, 101));
   if (ctr % 5 == 0) Console.WriteLine();
}

Console.WriteLine("\n20 random integers from 1000 to 10000:");
for (int ctr = 1; ctr <= 20; ctr++)
{
   Console.Write("{0,8}", rnd.Next(1000, 10001));
   if (ctr % 5 == 0) Console.WriteLine();
}

Console.WriteLine("\n20 random integers from 1 to 10:");
for (int ctr = 1; ctr <= 20; ctr++)
{
   Console.Write("{0,6}", rnd.Next(1, 11));
   if (ctr % 5 == 0) Console.WriteLine();
}

Console.WriteLine("-----------------Example 4------------------------");

Random rnd = new Random(); // this does not generate a number currently
string[] malePetNames = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska" };
string[] femalePetNames = { "Maggie", "Penny", "Saya", "Princess",
                            "Abby", "Laila", "Sadie", "Olivia",
                            "Starlight", "Talla" };

// Generate random indexes for pet names.
int mIndex = rnd.Next(0, malePetNames.Length);
int fIndex = rnd.Next(0, femalePetNames.Length);

// Display the result.
Console.WriteLine("Suggested pet name of the day: ");
Console.WriteLine("   For a male:     {0}", malePetNames[mIndex]);
Console.WriteLine("   For a female:   {0}", femalePetNames[fIndex]);


Console.WriteLine("-----------------Example 5------------------------");

Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}



//  This code reverses a message, counts the number of times 
 //  a particular character appears, then prints the results
//   to the console window.
 

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");

Random dice = new();
int roll = dice.Next(1, 7);
Console.WriteLine($"The randomly generated number is: {roll} ");
*/

int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
