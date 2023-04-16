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

Console.WriteLine("\n\n\nPrese any key to start the quiz...");
Console.ReadLine();
Console.Clear();
Console.WriteLine("Quiz Taker name:" + name);
Console.WriteLine("Question #1: Calculate the Geometric Mean of 4, 5 and 6.25");
Console.WriteLine("\nA. 5 ");
Console.WriteLine("B. 5.083");
Console.WriteLine("C. 5\u221A5");
Console.WriteLine("D. 25");

Console.Write("Answer:");
answerInput = Console.ReadLine().ToUpper();

if (answerInput =="A")
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
Console.WriteLine(answerInput);
Console.WriteLine("Please any key to move onto the next question");
Console.ReadLine();
Console.Clear();
Console.WriteLine("Quiz Taker name:" + name);
Console.WriteLine("Question #2:The Harmonic Mean of three numbers is 6.\r\nThe first nmber is 3 and the third number is two times the second number.\r\nWhat is the second number?");
Console.WriteLine("\nA. 5");
Console.WriteLine("B. 6");
Console.WriteLine("C. 9");
Console.WriteLine("D. 18");
Console.Write("Answer:");
answerInput = Console.ReadLine().ToUpper();
if (answerInput == "C")
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
Console.Clear();
Console.WriteLine("Quiz Taker name:" + name);
Console.WriteLine("Question 3:The Harmonic Mean of two numbers is 8\r\n\r\nOne of the numbers is 20. What is the other number?");
Console.WriteLine("\nA. 32");
Console.WriteLine("B. 12");
Console.WriteLine("C. 6");
Console.WriteLine("D. 5");
Console.WriteLine("Answer:");
answerInput= Console.ReadLine().ToUpper();

if (answerInput == "D")
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
Console.Clear();
/*
Console.WriteLine("Quiz Taker name:" + name);
Console.WriteLine("Question 4: The Harmonic Mean of three consective whole numbers is \n\n1080 \n\u2500\u2500\u2500\u2500\n121 \nWhat are the three whole numbers?");
Console.WriteLine("");
Console.WriteLine("Answer:");
answerInput= Console.ReadLine();
*/


Console.WriteLine("Number Coreect:" + numCoreect);
Console.WriteLine("Number Incorrect:" + numIncorrect);
Console.WriteLine("Total Socore:" +numCoreect + "/" + numTotal);
