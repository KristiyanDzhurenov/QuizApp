Console.WriteLine("Enter your username: "); // Input and Welcome the user
string userName = Console.ReadLine();

Console.WriteLine($"Hello {userName} how are you?");
Console.WriteLine("Choose quiz: Football(F) or Basketball(B)"); // Which quiz he wants

string quiz =  Console.ReadLine();
Console.WriteLine("Choose the difficulty: Easy, Intermediate, Insanity");

string difficult = Console.ReadLine(); // Ask for difficulty



// Find which quiz he choose
if (quiz == "Football" || quiz == "F") // Checking if it is Football
{
    switch (difficult)
    {
        case "Easy": // Easy difficulty
            Console.WriteLine("Where was born Lionel Messi:");
            Console.WriteLine("A: Brazil");
            Console.WriteLine("B: Japan");
            Console.WriteLine("C: Portugal");
            Console.WriteLine("D: Argentina");
            string answer = Console.ReadLine(); // Ask for the answer
            if (answer == "D" || answer == "Argentina" || answer == "D: Argentina")
            {
                Console.WriteLine("Correct answer! :)");
            }

            else
            {
                Console.WriteLine("Incorrect! :( ");
                Console.WriteLine("The correct answer was - D: Argentina");
                return; // Exectuing the program
            }

            Console.WriteLine("Do you want to continue: Y/N?");
            string wantToContinue = Console.ReadLine();
            if (wantToContinue == "Y" || wantToContinue == "y")
            {
                Console.WriteLine("Where was born Cristiano Ronaldo:");
                Console.WriteLine("A: Uruguay");
                Console.WriteLine("B: Portugal");
                Console.WriteLine("C: Bulgaria");
                Console.WriteLine("D: Germany");

                string answer2 = Console.ReadLine();
                if (answer2 == "Portugal" || answer2 == "B" || answer2 == "B: Portugal")
                {
                    Console.WriteLine("Correct answer again! You are very close to the final!!! :)");
                }
                else
                {
                    Console.WriteLine("Incorrect answer! Go next :( ");
                    Console.WriteLine("The correct answer was - B: Portugal");
                    return; // Exectuing the program
                }   
            }
            else if (wantToContinue == "N" || wantToContinue == "n")
            {
                return;
            }

            Console.WriteLine("Do you want to continue: Y/N?");
            string wantToContinueAgain = Console.ReadLine();
            if (wantToContinueAgain == "Y" || wantToContinueAgain == "y")
            { 
                Console.WriteLine("Who won the last European Championship: ");
                Console.WriteLine("A: Germany");
                Console.WriteLine("B: England");
                Console.WriteLine("C: Spain");
                Console.WriteLine("D: Croatia");

                string answer3 = Console.ReadLine();
                if (answer3 == "Spain" || answer3 == "C" || answer3 == "C: Spain")
                {
                    Console.WriteLine("Congratulations you won the quiz!!! :)");
                }

                else if (wantToContinueAgain == "N" || wantToContinueAgain == "n")
                {
                    return; // Exectuing the program
                }

                else
                {
                    Console.WriteLine("You were so close to win the quiz! Try again! I believe in you!!! :)");
                    Console.WriteLine("The correct answer was - C: Spain");
                    return; // Exectuing the program
                }
            } 

            break;

        case "Intermediate":
            Console.WriteLine("Who won the World Cup 2018:");
            Console.WriteLine("A: Brazil");
            Console.WriteLine("B: Croatia");
            Console.WriteLine("C: Belgium");
            Console.WriteLine("D: France");

            string answerForIntermediate = Console.ReadLine();
            if (answerForIntermediate == "D" || answerForIntermediate == "France" || answerForIntermediate == "D: France")
            {
                Console.WriteLine("Correct answer! :)");
            }

            else
            {
                Console.WriteLine("Incorrect! :( ");
                Console.WriteLine("The correct answer was - D: France");
                return; // Exectuing the program
            }

            Console.WriteLine("Do you want to continue: Y/N?");
            string wantToContinueInIntermediate = Console.ReadLine();

            if (wantToContinueInIntermediate == "Y" || wantToContinueInIntermediate == "y")
            {
                Console.WriteLine("Who won the World Cup 2022:");
                Console.WriteLine("A: Uruguay");
                Console.WriteLine("B: Portugal");
                Console.WriteLine("C: France");
                Console.WriteLine("D: Argentina");
                string answer2InIntermediate= Console.ReadLine();

                if (answer2InIntermediate == "Argentina" || answer2InIntermediate == "D" || answer2InIntermediate == "D: Argentina")
                {
                    Console.WriteLine("Correct answer again! You are very close to the final!!! :)");
                }
                else
                {
                    Console.WriteLine("Incorrect answer! Go next :( ");
                    Console.WriteLine("The correct answer was - D: Argentina");
                    return; // Exectuing the program
                }
            }

            else if (wantToContinueInIntermediate == "N" || wantToContinueInIntermediate == "n")
            {
                return; // Exectuing the program
            }

            Console.WriteLine("Do you want to continue: Y/N?");
            string wantToContinueAgaInIntermediate = Console.ReadLine();
            if (wantToContinueAgaInIntermediate == "Y" || wantToContinueAgaInIntermediate == "y")
            {
                Console.WriteLine("Who won the last Golden Ball: ");
                Console.WriteLine("A: Cristiano Ronaldo");
                Console.WriteLine("B: Erling Haaland");
                Console.WriteLine("C: Virgil van Dijk");
                Console.WriteLine("D: Lionel Messi");
                string answer3 = Console.ReadLine();

                if (answer3 == "Lionel Messi" || answer3 == "D" || answer3 == "D: Lionel Messi")
                {
                    Console.WriteLine("Congratulations you won the quiz!!! :)");
                }

                else if (wantToContinueAgaInIntermediate == "N" || wantToContinueAgaInIntermediate == "n")
                {
                    return; // Exectuing the program
                }
                else
                {
                    Console.WriteLine("You were so close to win the quiz! Try again! I believe in you!!! :)");
                    Console.WriteLine("The correct answer was - D: Lionel Messi");
                    return; // Exectuing the program
                }
            }

            break;
            
        case "Insanity":
            Console.WriteLine("Who won the World Cup 2010:");
            Console.WriteLine("A: Brazil");
            Console.WriteLine("B: Croatia");
            Console.WriteLine("C: Spain");
            Console.WriteLine("D: Italy");
            string answerForInsanity = Console.ReadLine();
            if (answerForInsanity == "C" || answerForInsanity == "Spain" || answerForInsanity == "C: Spain")
            {
                Console.WriteLine("Correct answer! :)");
            }
            else
            {
                Console.WriteLine("Incorrect! :( ");
                Console.WriteLine("The correct answer was - C: Spain");
                return; // Exectuing the program
            }
            Console.WriteLine("Do you want to continue: Y/N?");
            string wantToContinueInInsanity = Console.ReadLine();
            if (wantToContinueInInsanity == "Y" || wantToContinueInInsanity == "y")
            {
                Console.WriteLine("Who won the World Cup 2014:");
                Console.WriteLine("A: England");
                Console.WriteLine("B: Germany");
                Console.WriteLine("C: France");
                Console.WriteLine("D: Italy");
                string answer2InInsanity = Console.ReadLine();
                if (answer2InInsanity == "Germany" || answer2InInsanity == "B" || answer2InInsanity == "B: Germany")
                {
                    Console.WriteLine("Correct answer again! You are very close to the final!!! :)");
                }
                else
                {
                    Console.WriteLine("Incorrect answer! Go next :( ");
                    Console.WriteLine("The correct answer was - B: Germany");
                    return; // Exectuing the program
                }
            }
            else if (wantToContinueInInsanity == "N" || wantToContinueInInsanity == "n")
            {
                return; // Exectuing the program
            }
            Console.WriteLine("Do you want to continue: Y/N?");
            string wantToContinueAgainInInsanity= Console.ReadLine();
            if (wantToContinueAgainInInsanity == "Y" || wantToContinueAgainInInsanity == "y")
            {
                Console.WriteLine("When Hristo Stoichkov won his Golden Ball: ");
                Console.WriteLine("A: 1996");
                Console.WriteLine("B: 1992");
                Console.WriteLine("C: 2000");
                Console.WriteLine("D: 1994");
                string answer3 = Console.ReadLine();
                if (answer3 == "1994" || answer3 == "D" || answer3 == "D: 1994")
                {
                    Console.WriteLine("Congratulations you won the quiz!!! :)");
                }
                else if (wantToContinueAgainInInsanity == "N" || wantToContinueAgainInInsanity == "n")
                {
                    return; // Exectuing the program
                }
                else
                {
                    Console.WriteLine("You were so close to win the quiz! Try again! I believe in you!!! :)");
                    Console.WriteLine("The correct answer was - D: 1994");
                    return; // Exectuing the program
                }
            }
            break;
    }
}
