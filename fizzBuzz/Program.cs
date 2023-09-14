// Fizz Buzz challenge
/*
Here are the FizzBuzz rules that you need to implement in your code project:

Output values from 1 to 100, one number per line, inside the code block of an iteration statement.
When the current value is divisible by 3, print the term Fizz next to the number.
When the current value is divisible by 5, print the term Buzz next to the number.
When the current value is divisible by both 3 and 5, print the term FizzBuzz next to the number.
*/
for (int i = 1; i <= 100; i ++)
{
    //Console.WriteLine($"{i} ");
    if (i % 5 == 0 && i % 3 == 0)
    {
        Console.WriteLine($"{i} - FizzBuzz ");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz ");
    }
    else if (i % 5 == 0 )
    {
        Console.WriteLine($"{i} - Buzz ");
    }
    else
    Console.WriteLine(i);
}
Console.WriteLine();
Console.WriteLine("--------------------------------Mi ahan Akkhulagoy Korlu------------------------");
Console.WriteLine(@"I can assert my credit here. I am Dipu Singha. I just saw the FizzBuzz problem
or the quesion. I just figured out how to solve that problem completely on my own.
This assertion proves I don't have imposter syndrome");
Console.WriteLine("----------------------------------Yeah. I did it in C#. -------------------------");
Console.WriteLine();