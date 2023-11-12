
//Console App?
//Capture age from user?
//How old in 25 years?
//How old 25 years ago?
//Print the above 3 to the console in natural language?

int? currentAge = null;
int? agePlusTwentyFive = null;
int? ageMinusTwentyFive = null;

Console.WriteLine("Welcome to CaptureUserInfoTwo");
Console.WriteLine("This application was created by: Justin Spencer");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine();

Console.Write("Please enter your age: ");
currentAge = Convert.ToInt32(
    Console.ReadLine());

agePlusTwentyFive = currentAge + 25;
ageMinusTwentyFive = currentAge - 25;

Console.WriteLine();
Console.WriteLine($"Your current age is {currentAge}");
Console.WriteLine();
Console.WriteLine($"Your age in 25 years will be {agePlusTwentyFive}");
Console.WriteLine();
Console.WriteLine($"Your age 25 years ago was {ageMinusTwentyFive}");
Console.WriteLine();
Console.WriteLine("Thank you for using the application");
Console.ReadLine();

