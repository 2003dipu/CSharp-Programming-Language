/*
Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine(@"Welcome to Number Guessing Game! Game Rules: In this number guessing game,
1: You set the range of a number's upper bound and lower bound.
2: Between your, Computer will randomly generate a number
3: You have to guess the number
4: If your guess is higher than the computer's number, Computer will let you know by saying 'Too big' and 'Too low'.
5: If you can guess the number correctly, You win the Game.");
Console.WriteLine("---------------------------------------------------------------------------");

int guess = 0;
int NumberOfGuesses = 0;

// Random number between the upper bound and the lower bound
Random random = new();
int lowerBound;
int upperBound;

Console.WriteLine("Enter the lower bound: ");
while (!int.TryParse(Console.ReadLine(), out lowerBound)) { Console.WriteLine("Enter an integer!"); }
Console.WriteLine("Enter the upper bound: ");
while (!int.TryParse(Console.ReadLine(), out upperBound)) { Console.WriteLine("Enter an integer!"); }
int number = random.Next(lowerBound, upperBound);

string? input;

do
{
    Console.WriteLine();
    Console.Write("Guess the number (type 'exit' to exit the game): ");
    input = Console.ReadLine();

    if (input == "exit")
    {
        Console.WriteLine("You exited the game.");
        break;
    }

    if (!int.TryParse(input, out guess))
    {
        Console.WriteLine("Invalid input! Enter an integer.");
        continue;
    }

    NumberOfGuesses++;

    if (guess == number)
    {
        Console.WriteLine($"{guess} is correct! You got it right!!! You are a genius!");
        Console.WriteLine($"This round took you {NumberOfGuesses} guesses.");
        break;
    }
    else if (guess > number)
    {
        Console.WriteLine($"{guess} is too high!");
    }
    else
    {
        Console.WriteLine($"{guess} is too low.");
    }
} while (true);

// Alternative code using for loop

Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine(@"Welcome to Number Guessing Game! Game Rules: In this number guessing game,
1: You set the range of a number's upper bound and lower bound.
2: Between your, Computer will randomly generate a number
3: You have to guess the number
4: If your guess is higher than the computer's number, Computer will let you know by saying 'Too big' and 'Too low'.
5: If you can guess the number correctly, You win the Game.");
Console.WriteLine("---------------------------------------------------------------------------");

// Random number between the upper bound and the lower bound
Random random = new();
int lowerBound;
int upperBound;

Console.WriteLine("Enter the lower bound: ");
while (!int.TryParse(Console.ReadLine(), out lowerBound)) { Console.WriteLine("Enter an integer!"); }
Console.WriteLine("Enter the upper bound: ");
while (!int.TryParse(Console.ReadLine(), out upperBound)) { Console.WriteLine("Enter an integer!"); }
int number = random.Next(lowerBound, upperBound);

int NumberOfGuesses = 0;

for (; ; )
{
    Console.WriteLine();
    Console.Write("Guess the number (type 'exit' to exit the game): ");
    string input = Console.ReadLine();

    if (input == "exit")
    {
        Console.WriteLine("You exited the game.");
        break;
    }

    if (!int.TryParse(input, out int guess))
    {
        Console.WriteLine("Invalid input! Enter an integer.");
        continue;
    }

    NumberOfGuesses++;

    if (guess == number)
    {
        Console.WriteLine($"{guess} is correct! You got it right!!! You are a genius!");
        Console.WriteLine($"This round took you {NumberOfGuesses} guesses.");
        break;
    }
    else if (guess > number)
    {
        Console.WriteLine($"{guess} is too high!");
    }
    else
    {
        Console.WriteLine($"{guess} is too low.");
    }
}
*/

// Alternative code 2------------------------
Console.WriteLine("---------------------------------------------------------------------------");
Console.WriteLine(@"Welcome to Number Guessing Game! Game Rules: In this number guessing game,
1: You set the range of a number's upper bound and lower bound.
2: Between your, Computer will randomly generate a number
3: You have to guess the number
4: If your guess is higher than the computer's number, Computer will let you know by saying 'Too big' and 'Too low'.
5: If you can guess the number correctly, You win the Game.");
Console.WriteLine("---------------------------------------------------------------------------");

// Random number between the upper bound and the lower bound
Random random = new();
int lowerBound;
int upperBound;

Console.WriteLine("Enter the lower bound: ");
while (!int.TryParse(Console.ReadLine(), out lowerBound)) { Console.WriteLine("Enter an integer!"); }
Console.WriteLine("Enter the upper bound: ");
while (!int.TryParse(Console.ReadLine(), out upperBound)) { Console.WriteLine("Enter an integer!"); }
int number = random.Next(lowerBound, upperBound);

int NumberOfGuesses = 0;
string? input = "";

while (input != "exit")
{
    Console.WriteLine();
    Console.Write("Guess the number (type 'exit' to exit the game): ");
    input = Console.ReadLine();

    if (input == "exit")
    {
        Console.WriteLine("You exited the game.");
        break;
    }

    if (!int.TryParse(input, out int guess))
    {
        Console.WriteLine("Invalid input! Enter an integer.");
        continue;
    }

    NumberOfGuesses++;

    if (guess == number)
    {
        Console.WriteLine($"{guess} is correct! You got it right!!! You are a genius!");
        Console.WriteLine($"This round took you {NumberOfGuesses} guesses.");
        break;
    }
    else if (guess > number)
    {
        Console.WriteLine($"{guess} is too high!");
    }
    else
    {
        Console.WriteLine($"{guess} is too low.");
    }
}
