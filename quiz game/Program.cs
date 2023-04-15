// See https://aka.ms/new-console-template for more information
int numRight = 0;
int numWrong = 0;
int numCoreect = 0;
int numTotal = 10;
string name;
string answerInput;
//string[]answerInput= new string[9];

Console.WriteLine("quiz questions taken from https://www.mathopolis.com/");
Console.WriteLine("Welcome to the quiz game. Please enter your name");
Console.Write("Name:");
name = Console.ReadLine();
Console.WriteLine("Welcome " + name +"!");

Console.WriteLine("\n\n\nPrese any key to continue...");
Console.ReadLine();
Console.WriteLine("Question #1: Calculate the Geometric Mean of 4, 5 and 6.25");
Console.Write("Answer:");
answerInput = Console.ReadLine();
if (answerInput =="5")
{
    Console.WriteLine("CORRECT");
    numCoreect+=1;
}
else
{
    Console.WriteLine("WRONG!");
    Console.WriteLine("Correct answer was 5");
}
Console.ReadLine() ;
Console.WriteLine(answerInput);
Console.WriteLine("Please any key to move onto the next question");
Console.ReadLine();

Console.WriteLine("Question #2:The Harmonic Mean of three numbers is 6.\r\nThe first nmber is 3 and the third number is two times the second number.\r\nWhat is the second number?");
Console.Write("Answer:");
answerInput = Console.ReadLine();
if (answerInput == "9")
{
    Console.WriteLine("CORRECT");
    numCoreect++;
}
else
{
    Console.WriteLine("WRONG!");
    Console.WriteLine("Correct answer was 9");
}
Console.WriteLine(answerInput);


Console.WriteLine(numCoreect + "/" + numTotal);
