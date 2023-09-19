
/*
// There are some alternative ways to loop through a range of numbers in C#, depending on your--------
// preference and needs. Here are some examples:
// Example 1 ---------------------------------------------
for (int num = 1; num < 20; num++)
{
    if (num % 2 == 0)
    {
        // Print a message and continue to the next iteration
        Console.WriteLine($"Found an even number {num}.  -----------Even!!! ");
        continue;
    }
    Console.WriteLine($"Found an odd number {num}.  ---------------Odd!!! ");

}

// Example 2 ---------------------------------------------Alternative code

// Loop through the numbers from 2 to 10
foreach (int num in Enumerable.Range(1, 20))
{
    // Check if the number is even or odd and print a message
    if (num % 2 == 0)
    {
        Console.WriteLine("Found an even number {0}", num);
    }
    else
    {
        Console.WriteLine("Found an odd number {0}", num);
    }
}

// Example 3 ---------------------------------------------Alternative code

// Initialize a counter variable
int num = 1;
// Loop while the counter is less than or equal to 10
while (num <= 20)
{
    // Check if the number is even or odd and print a message
    if (num % 2 == 0)
    {
        Console.WriteLine($"Found an even number {num}");
    }
    else
    {
        Console.WriteLine($"Found an odd number {num}");
    }
    // Increment the counter by 1
    num++;
}


// Example 4 ---------------------------------------------Alternative Code

// Initialize a counter variable
int num = 1;
// Loop until the counter is greater than 10
do
{
    // Check if the number is even or odd and print a message
    if (num % 2 == 0)
    {
        Console.WriteLine($"Found an even number {num}");
    }
    else
    {
        Console.WriteLine($"Found an odd number {num}");
    }
    // Increment the counter by 1
    num++;
} while (num <= 20);


// Example 5 ---------------------------------------------Alternative code

// Define a method that takes an integer as a parameter and checks if it is even or odd
static void CheckEvenOdd(int num)
{
    // If the number is divisible by 2, it is even
    if (num % 2 == 0)
    {
        // Print a message and return from the method
        Console.WriteLine($"Found an even number {num}.  -----------Even!!! ");
        return;
    }
    // Otherwise, the number is odd
    Console.WriteLine($"Found an odd number {num}.  ---------------Odd!!! ");
}

// Use a for loop to iterate from 1 to 20
for (int num = 1; num <= 20; num++)
{
    // Call the method with the current number as an argument
    CheckEvenOdd(num);
}



// I can try to shorten the code by using a ternary operator instead of an if-else statement.
// A ternary operator is a shorthand way of writing a conditional expression that has the form
// condition ? true_value : false_value

// Example 6 ---------------------------------------------Alternative code()----------------------------------
// Define a method that takes an integer as a parameter and checks if it is even or odd
static void CheckEvenOdd(int num)
{
    // Use a ternary operator to print the appropriate message based on the condition
    Console.WriteLine(num % 2 == 0 ? $"Found an even number {num}.  -----------Even!!! " : $"Found an odd number {num}.  ---------------Odd!!! ");
}

// Use a for loop to iterate from 1 to 20
for (int num = 1; num <= 20; num++)
{
    // Call the method with the current number as an argument
    CheckEvenOdd(num);
}
// --------------- The above 6 alternative code solutions should walk you through the C# language--------------
*/
// Example 7 ---------------------------------------------Alternative code with user input----------------------

Console.WriteLine();
Console.WriteLine(@"----------------  Welcome to even and odd number determination! --------------------------
Enter the highest number to find the even numbers and odd numbers between the range 1 through n!");
Console.Write("Enter the highest number: ");
int num;
while (true)
{
    Console.Write("Enter the highest number: ");
    if (int.TryParse(Console.ReadLine(), out num))
    {
        break; // Exit the loop if a valid integer is entered.
    }
    else
    {
        Console.WriteLine("Enter a valid integer!");
    }
}
for (int i = 0; i <= num; i++)
{
    Console.WriteLine(i % 2 == 0 ? $"Found an even number {i} " : $"Found an odd number  {i} ");

}

Console.WriteLine();

