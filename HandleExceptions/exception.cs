/*

static void ExceptionHandle()
{
    try
    {
        // code that may cause an exception
        int a = 10;
        int b = 0;
        int result = a / b; // this will throw a DivideByZeroException
        Console.WriteLine(result);
    }
    catch (DivideByZeroException ex)
    {
        // code that handles the exception
        Console.WriteLine(ex.Message);
    }
}

ExceptionHandle();


class Program
{
    static void Main()
    {
        try
        {
            // code that may cause an exception
            int[] numbers = {1, 2, 3};
            Console.WriteLine(numbers[3]); // this will throw an IndexOutOfRangeException
        }
        catch (IndexOutOfRangeException ex)
        {
            // code that handles the exception
            Console.WriteLine("Invalid index: " + ex.Message);
        }
    }
}

// example ----------------

using System;

class Program
{
    static void Main()
    {
        try
        {
            // code that may cause different exceptions
            int[] numbers = {1, 2, 3};
            Console.Write("Enter a index number: ");
            int index = int.Parse(Console.ReadLine()); // this may throw a FormatException if the input is not a number
            Console.WriteLine(numbers[index]); // this may throw an IndexOutOfRangeException if the index is out of range
        }
        catch (FormatException ex)
        {
            // code that handles the format exception
            Console.WriteLine("Invalid input: " + ex.Message);
        }
        catch (IndexOutOfRangeException ex)
        {
            // code that handles the index out of range exception
            Console.WriteLine("Invalid index: " + ex.Message);
        }
    }
}



using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Declare a FileStream object outside the try block
        FileStream fs = null;
        try
        {
            // Create a new file stream and write some data
            fs = new FileStream("test.txt", FileMode.Create);
            byte[] data = {65, 66, 67};
            fs.Write(data, 0, data.Length);
            Console.WriteLine("Data written successfully.");
            // Throw an exception to simulate an error
            throw new Exception("Something went wrong.");
        }
        catch (Exception ex)
        {
            // Handle the exception
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            // Clean up the file stream resource
            if (fs != null)
            {
                fs.Close();
                Console.WriteLine("File stream closed.");
            }
        }
    }
}


// prints or displays the current time

var date = DateTime.Now;
Console.WriteLine(date);



var Date_Time = DateTime.Now;
for (int i=0;i<=3;i++)
{
    Console.WriteLine(i);
    Console.WriteLine(Date_Time);
}

var rand = new Random();
for (int i = 0; i < 7; i++)
{
 Console.WriteLine($"Coin flip: {(rand.NextDouble() < 0.5 ? "heads" : 
"tails")}");
}

//Random random = new();
//int[] find_odd_even = {random.Next(1,20)};
// Exercise----------------------------------
int[] a = new int[10];
for (int i = 0; i < a.Length; i++)
{
 a[i] = i * i;
}
for (int i = 0; i < a.Length; i++)
{
 Console.WriteLine($"a[{i}] = {a[i]}");
}


// practice exception  -------1
string[] names = { "Dog", "Cat", "Fish" };
Object[] objs = names;

Object obj = 13;
objs[2] = obj; // ArrayTypeMismatchException occurs
Console.WriteLine(obj);

// practice exception  -------2
int valueEntered;
string userValue = "two";
valueEntered = int.Parse(userValue); // FormatException occurs
Console.WriteLine(valueEntered);

// practice exception  -------3
int[] values1 = { 3, 6, 9, 12, 15, 18, 21 };
int[] values2 = new int[6];

values2[values1.Length - 1] = values1[values1.Length - 1]; // IndexOutOfRangeException occurs

// practice exception  -------4 > invalid cast exception
object obj = "This is a string";
int num = (int)obj;

// practice exception  -------5 > null reference exception
int[] values = null;
for (int i = 0; i <= 9; i++)
    values[i] = i * 2;


string? lowCaseString = null;
Console.WriteLine(lowCaseString.ToUpper());

// practice exception  -------6 > overflow exception
decimal x = 400;
byte i;

i = (byte)x; // OverflowException occurs
Console.WriteLine(i);

// new code project to catch exceptions
double float1 = 3000.0;
double float2 = 0.0;
int number1 = 3000;
int number2 = 0;
try
{
    Console.WriteLine($"Floating point number divided by zero always produces infinity: {float1 / float2}");
    Console.WriteLine(number1 / number2);
}
catch
{
    Console.WriteLine("An exception has been caught");
}
Console.WriteLine("Exit program");



try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch
    {
        Console.WriteLine("Exception caught on Process1!");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
}

// Tick-tac-toe game

using System;

public class TicTacToeGame
{
    private const int BoardSize = 3;

    private readonly char[,] board = new char[BoardSize, BoardSize];
    private char currentPlayer = 'X';

    public void Start()
    {
        InitializeBoard();

        while (!IsGameOver())
        {
            MakeMove();
        }

        DisplayWinner();
    }

    private void InitializeBoard()
    {
        for (int i = 0; i < BoardSize; i++)
        {
            for (int j = 0; j < BoardSize; j++)
            {
                board[i, j] = '-';
            }
        }
    }

    private void MakeMove()
    {
        Console.WriteLine($"Player {currentPlayer}'s turn. Enter a square number (1-9): ");
        int squareNumber = int.Parse(Console.ReadLine());

        int row = (squareNumber - 1) / BoardSize;
        int column = (squareNumber - 1) % BoardSize;

        if (board[row, column] == '-')
        {
            board[row, column] = currentPlayer;
            currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
        }
        else
        {
            Console.WriteLine("Square is already taken. Try again.");
        }
    }

    private bool IsGameOver()
    {
        // Check for winner
        for (int i = 0; i < BoardSize; i++)
        {
            if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != '-')
            {
                return true;
            }
        }

        for (int i = 0; i < BoardSize; i++)
        {
            if (board[0, i] == board[1, i] && board[1, i] == board[2, i] && board[0, i] != '-')
            {
                return true;
            }
        }

        if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != '-')
        {
            return true;
        }

        if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != '-')
        {
            return true;
        }

        // Check for draw
        for (int i = 0; i < BoardSize; i++)
        {
            for (int j = 0; j < BoardSize; j++)
            {
                if (board[i, j] == '-')
                {
                    return false;
                }
            }
        }

        return true;
    }

    private void DisplayWinner()
    {
        if (IsGameOver())
        {
            Console.WriteLine($"Player {currentPlayer} wins!");
        }
        else
        {
            Console.WriteLine("Draw!");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        var game = new TicTacToeGame();
        game.Start();
    }
}



try
{
    Process1();
}
catch
{
    Console.WriteLine("An exception has occurred");
}

Console.WriteLine("Exit program");

static void Process1()
{
    try
    {
        WriteMessage();
    }
    catch (DivideByZeroException dipu)
    {
        Console.WriteLine($"Exception caught in Process1: {dipu.Message} ");
    }
}

static void WriteMessage()
{
    double float1 = 3000.0;
    double float2 = 0.0;
    int number1 = 3000;
    int number2 = 0;
    byte smallNumber;

    Console.WriteLine(float1 / float2);
    Console.WriteLine(number1 / number2);
    checked
    {
        smallNumber = (byte)number1;
    }
}


// inputValues is used to store numeric values entered by a user
string[] inputValues = new string[]{"three", "9999999999", "0", "2" };

foreach (string inputValue in inputValues)
{
    int numValue;
    try
    {
        numValue = int.Parse(inputValue);
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid readResult. Please enter a valid number.");
    }
    catch (OverflowException)
    {
        Console.WriteLine("The number you entered is too large or too small.");
    }
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}


checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer. " + ex.Message);
    }
}

try
{
    string? str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null. " + ex.Message);
}

try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range. " + ex.Message);
}

try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero. " + ex.Message);
}

Console.WriteLine("Exiting program.");

// https://learn.microsoft.com/en-us/training/modules/introduction-power-platform/
//4-explore-connectors-microsoft-dataverse/
// gcc --version
//g++ --version
//gdb --version


//ArgumentException invalidArgumentException = new ArgumentException();

ArgumentException invalidArgumentException = new ArgumentException(@"ArgumentException: The 'GraphData' method 
received data outside the expected range.");
throw invalidArgumentException;

throw new FormatException(@"FormatException: Calculations in process XYZ have been cancelled
due to invalid data format.");


string[][] userEnteredValues = new string[][]
{
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
};

foreach (string[] userEntries in userEnteredValues)
{
    try
    {
        BusinessProcess1(userEntries);
    }
    catch (Exception ex)
    {
        if (ex.StackTrace.Contains("BusinessProcess1") && (ex is FormatException))
        {
            Console.WriteLine(ex.Message);
        }
    }
}

static void BusinessProcess1(String[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);

            // completes required calculations based on userValue
            // ...
        }
        catch (FormatException)
        {
            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            throw invalidFormatException;
        }
    }
}


try
{
    OperatingProcedure1();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.WriteLine("Exiting application.");
}

static void OperatingProcedure1()
{
    string[][] userEnteredValues = new string[][]
    {
        new string[] { "1", "two", "3"},
        new string[] { "0", "1", "2"}
    };

    foreach(string[] userEntries in userEnteredValues)
    {
        try
        {
            BusinessProcess1(userEntries);
        }
        catch (Exception ex)
        {
            if (ex.StackTrace.Contains("BusinessProcess1"))
            {
                if (ex is FormatException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Corrective action taken in OperatingProcedure1");
                }
                else if (ex is DivideByZeroException)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Partial correction in OperatingProcedure1 - further action required");

                    // re-throw the original exception
                    throw;
                }
                else
                {
                    // create a new exception object that wraps the original exception
                    throw new ApplicationException("An error occurred - ", ex);
                }
            }
        }

    }
}

static void BusinessProcess1(String[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        try
        {
            valueEntered = int.Parse(userValue);

            checked
            {
                int calculatedValue = 4 / valueEntered;
            }
        }
        catch (FormatException)
        {
            FormatException invalidFormatException = new FormatException("FormatException: User input values in 'BusinessProcess1' must be valid integers");
            throw invalidFormatException;
        }
        catch (DivideByZeroException)
        {
            DivideByZeroException unexpectedDivideByZeroException = new DivideByZeroException("DivideByZeroException: Calculation in 'BusinessProcess1' encountered an unexpected divide by zero");
            throw unexpectedDivideByZeroException;

        }
    }
}
*/

/*
int.TryParse(Console.ReadLine(), out int dipu);
Console.WriteLine(dipu);
string userInput = "123.456";
decimal parsedDecimal = decimal.Parse(userInput);
double floatingPointValue = 123.456;
int parsedInteger = (int)Math.Floor(floatingPointValue);
double floatingPointValue = 123.456;
int parsedInteger = (int)floatingPointValue;




// Prompt the user for the lower and upper bounds
Console.Write("Enter the lower bound: ");
int lowerBound = int.Parse(Console.ReadLine());


Console.Write("Enter the upper bound: ");
int upperBound = int.Parse(Console.ReadLine());

decimal averageValue = 0;
bool exit = false;

do
{
    try
    {
        // Calculate the sum of the even numbers between the bounds
        averageValue = AverageOfEvenNumbers(lowerBound, upperBound);

        // Display the result to the user
        Console.WriteLine($"The average of even numbers between {lowerBound} and {upperBound} is {averageValue}.");

        exit = true;
    }
    catch (ArgumentOutOfRangeException ex)
    {
        Console.WriteLine("An error has occurred.");
        Console.WriteLine(ex.Message);
        Console.WriteLine($"The upper bound must be greater than {lowerBound}");
        Console.Write($"Enter a new upper bound (or enter Exit to quit): ");
        string? userResponse = Console.ReadLine();
        if (userResponse.ToLower().Contains("exit"))
        {
            exit = true;
        }
        else
        {
            exit = false;
            upperBound = int.Parse(userResponse);
        }
    }    
} while (exit == false);

// Wait for user input
Console.ReadLine();
if (lowerBound >= upperBound)
{
    throw new ArgumentOutOfRangeException("upperBound", "ArgumentOutOfRangeException: upper bound must be greater than lower bound.");
}

int sum = 0;
static decimal AverageOfEvenNumbers(int lowerBound, int upperBound)
{
    int sum = 0;
    int count = 0;
    decimal average = 0;

    for (int i = lowerBound; i <= upperBound; i++)
    {
        if (i % 2 == 0)
        {
            sum += i;
            count++;
        }
    }

    average = (decimal)sum / count;

    return average;
}
*/
string[][] userEnteredValues = new string[][]
{
            new string[] { "1", "2", "3"},
            new string[] { "1", "two", "3"},
            new string[] { "0", "1", "2"}
};

try
{
    Workflow1(userEnteredValues);
    Console.WriteLine("'Workflow1' completed successfully.");

}
catch (DivideByZeroException ex)
{
    Console.WriteLine("An error occurred during 'Workflow1'.");
    Console.WriteLine(ex.Message);
}

static void Workflow1(string[][] userEnteredValues)
{
    foreach (string[] userEntries in userEnteredValues)
    {
        try
        {
            Process1(userEntries);
            Console.WriteLine("'Process1' completed successfully.");
            Console.WriteLine();
        }
        catch (FormatException ex)
        {
            Console.WriteLine("'Process1' encountered an issue, process aborted.");
            Console.WriteLine(ex.Message);
            Console.WriteLine();
        }
    }
}

static void Process1(String[] userEntries)
{
    int valueEntered;

    foreach (string userValue in userEntries)
    {
        bool integerFormat = int.TryParse(userValue, out valueEntered);

        if (integerFormat == true)
        {
            if (valueEntered != 0)
            {
                checked
                {
                    int calculatedValue = 4 / valueEntered;
                }
            }
            else
            {
                throw new DivideByZeroException("Invalid data. User input values must be non-zero values.");
            }
        }
        else
        {
            throw new FormatException("Invalid data. User input values must be valid integers.");
        }
    }
}
