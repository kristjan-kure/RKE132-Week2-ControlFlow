/* 
 Asking user age:
 * Based on the input, application displays:
 * age < 13 OR age >= 0 "You are too young to use Instagram". 
 * other possible age values - "Welcome to Instagram"
 * non valid values return error.

 Possible inputs:   
 * non-numeric value (e.g 13g) 
 * less than 0 value
 * 0 value
 * 12 value
 * 13 value
 * 14 value
 * over 100 value
*/

// Asking user age
Console.WriteLine("Welcome, nice to see you! Please, enter your age in years:");

// Age as string from console 
string userAge = Console.ReadLine();

// Default value
int userAgeNum = 0;

// Parse input
bool isAgeNumber = Int32.TryParse(userAge, out userAgeNum);

if (isAgeNumber)
{
    // user age = 0 - 12
    if (userAgeNum < 13 && userAgeNum >= 0)
    {
        Console.WriteLine("You are too young to use Instagram");
    }
    // user age = 13 or 13+
    else if (userAgeNum >= 13 && userAgeNum <= 100)
    {
        Console.WriteLine("Welcome to Instagram!");
    }
    // user age 100 or 100+
    else if (userAgeNum > 100)
    {
        Console.WriteLine($"Welcome to Instagram! You are {userAgeNum} years old! Is this correct?");
    }
    // user age is negative
    else
    {
        Console.WriteLine("Error! Your age cant be negative! Please try again.");
    }
}
else
{
    Console.WriteLine("Error! Your age is not a number. Please try again.");
}

