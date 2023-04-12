// See https://aka.ms/new-console-template for more information
int numRight = 0;
int numWrong = 0;
String name = "";
string answerInput;

Console.WriteLine("quiz questions taken from collegiate.quizbowlpackets.com");
Console.WriteLine("Welcome to the quiz game. Please enter your name");
Console.Write("Name:");
name= Console.ReadLine();
Console.WriteLine("Welcome " + name +"!");
Console.WriteLine("\n\n\nPrese any key to continue...");
Console.ReadLine();
Console.WriteLine("Question #1: Calculate the Geometric Mean of 4, 5 and 6.25");
Console.Write("Answer:");
answerInput = Console.ReadLine();
if (answerInput=="5")
{
    Console.WriteLine("CORRECT");
}
else
{
    Console.WriteLine("WRONG!");
}
Console.WriteLine(answerInput);
