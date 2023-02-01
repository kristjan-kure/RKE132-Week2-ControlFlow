/* 
 * Asking user sex (m/f)
 * Asking user last name
 * Based on the selection, application greets the user:
 * Welcome, Mr. [user last name]! / Welcome, Ms. [user last name]!
*/

Console.WriteLine("Hello, nice to see you! Please, select your gender (m/f):");
char userGender = Char.Parse(Console.ReadLine());

Console.WriteLine("Please, enter your last name:");
string userLastName = Console.ReadLine();

// user sex = male
if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
// user sex = female
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
// user sex = unknown
else
{
    Console.WriteLine($"Welcome, {userLastName}!");
}
