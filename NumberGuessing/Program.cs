Console.WriteLine();
Console.WriteLine(@"Welcome to Number Guessing Game! \n Game Rules: In this number guessing game,
1: You set the range of a number's upper bound and lower bound.
2: Between your, Computer will randomly generate a number
3: You have to guess the number
4: If your guess is higher than the computer's number, Computer will let you know by saying 'Too big' and 'Too low'.
5: If you can guess the number correctly, You win the Game.");
int guess = 0;
int NumberOfGuesses = 0;
// Random number between the upper bound and the lower bound----------------------------------------
Random random = new();
int lowerBound;
int upperBound;
Console.WriteLine("Enter the lower bound: ");
while (!int.TryParse(Console.ReadLine(), out lowerBound)) { Console.WriteLine("Enter an integer!"); }
Console.WriteLine("Enter the upper bound: ");
while (!int.TryParse(Console.ReadLine(), out upperBound)) { Console.WriteLine("Enter an integer!"); }
int number = random.Next(lowerBound, upperBound);
// Random number generation ends here----------------------------------------------------------------
bool running = false;
void GameLoop()
{
    while (guess != number && !running )
    {
        Console.WriteLine();
        Console.Write("Guess the number: ");
        while (!int.TryParse(Console.ReadLine(), out guess)) { Console.WriteLine("Invalid number!Enter an integer."); }

        if (guess == number)
        {
            Console.WriteLine($"{guess} is correct!-------------You got it right!!!-------You are a genius-------");
            Console.WriteLine($"This round took you {NumberOfGuesses} guesses though! ");
            running = false;
            break;
        }
        
        else if (guess > number)
        {
            Console.WriteLine($"{guess} is too high! ");
        }
        else
        {
            Console.WriteLine($"{guess} is too low ");
        }
        NumberOfGuesses++;
    }

}
GameLoop();