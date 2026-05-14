Console.WriteLine("Enter a number:");

double myNumber = 0.0;

string userInput = Console.ReadLine();

myNumber = double.Parse(userInput);

Console.WriteLine("You entered " + userInput);

Console.WriteLine("Enter a number:");

double myNumber2 = double.Parse(Console.ReadLine());

Console.WriteLine($"The sum of your numbers " +
    $"{myNumber} and {myNumber2} is: {myNumber + myNumber2}");

Console.ReadKey();

