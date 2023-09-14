/*
Console.WriteLine("First calling of the method");
CountTo(5);
Console.WriteLine();
void CountTo(int max) 
{
	for (int i = 0; i < max; i++)
	{
		Console.Write($"${i}, ");
	}
}
Console.WriteLine();
Console.WriteLine("Second calling of the method");
CountTo(6);
int[] schedule = { 800, 1200, 1600, 2000 };
void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }
    for (int i = 0; i < times.Length; i++)
    {
        int newTime = (times[i] + diff) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}
DisplayAdjustedTimes(schedule, 6,-6);


string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor", "Anushka", "Amit"};

DisplayStudents(students); // first call
DisplayStudents(new string[] {"Dipu","Rosmi"}); // second call

void DisplayStudents(string[] students) 
{
    foreach (string student in students) 
    {
        Console.Write($"{student}, ");
    }
    Console.WriteLine();
}

PrintCircleArea(12);

void PrintCircleArea(int radius)
{
    double pi = 3.14159;
    double area = pi * (radius * radius);
    Console.WriteLine($"Area = {area}");
}
*/
// Project: calculator; to calculate a circle's area and circumference---------------------------------------------
Console.WriteLine();
int radius;
void CalculateCircumference()
{   
    Console.Write("Enter the radius of a circle to calculate its Circumference and Area: ");
    while (!int.TryParse(Console.ReadLine(), out radius)){
        Console.WriteLine("--------Invalid number!-------\nEnter a valid integer. ");
    }
    decimal pi = 3.14159m;
    decimal circumference = 2 * pi * radius;
    decimal area = pi * radius * radius;
    Console.WriteLine($"Circle with radius {radius}\nCircumference: {circumference:N2}\nArea:{area:N2} ");
    
}
CalculateCircumference();
Console.WriteLine();
// Calculate another circle's area and circumference
void CalculateArea()
{   
    Console.Write("Enter the radius of another circle to calculate its Circumference and Area: ");
    while (!int.TryParse(Console.ReadLine(), out radius)){
        Console.WriteLine("--------Invalid number!-------\nEnter a valid integer. ");
    }
    
    decimal pi = 3.14159m;
    decimal area = pi * radius*radius;
    decimal circumference = 2 * pi * radius;
    Console.WriteLine($"Circle with radius {radius}:\nArea:  {area:N2}\nCircumference:{circumference:N2} ");
}
CalculateArea();
Console.WriteLine();
// ---------------------------------------------------------------------------------------------------------------