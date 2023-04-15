// See https://aka.ms/new-console-template for more information

int numCoreect = 0;
int numIncorrect = 0;
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
    numIncorrect+=1;
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
    numCoreect += 1;
}
else
{
    numIncorrect+=1;
    Console.WriteLine("WRONG!");
    Console.WriteLine("Correct answer was 9");
}
Console.WriteLine(answerInput);
Console.WriteLine("Please any key to move onto the next question");
Console.ReadLine();
Console.WriteLine("Question 3:The Harmonic Mean of two numbers is 8\r\n\r\nOne of the numbers is 20. What is the other number?");
answerInput= Console.ReadLine();

if (answerInput == "5")
{
    Console.WriteLine("CORRECT!");
    numCoreect += 1;
}
else
{
    numIncorrect+=1;
    Console.WriteLine("WRONG!");
    Console.WriteLine("Correct answer was 5");
}
Console.WriteLine("Please any key to move onto the next question");
Console.ReadLine();
Console.WriteLine("Question 4: [cached] 0.049829483032227 ms\r\n\r\nWhat are the three whole numbers?");
//answerInput= Console.ReadLine();


Console.WriteLine("Number Coreect:" + numCoreect);
Console.WriteLine("Number Incorrect:" + numIncorrect);
Console.WriteLine("Total Socore:" +numCoreect + "/" + numTotal);
