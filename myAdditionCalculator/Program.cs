Console.WriteLine("Enter the first whole number:");

int myNumber = 0;

string userInput = Console.ReadLine();

myNumber = int.Parse(userInput);

Console.WriteLine("You entered " + userInput);

Console.WriteLine("Enter the second whole number:");

int myNumber2 = int.Parse(Console.ReadLine());

Console.WriteLine($"The sum of your numbers " +
    $"{myNumber} and {myNumber2} is: {myNumber + myNumber2}");

Console.ReadKey();

