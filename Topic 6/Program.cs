using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace Topic_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void navPrompter()
            {
                int prompterMax = 0;
                int prompterMin = 0;
                int prompter;
                bool prompterMinMaxValid = false;
                bool prompterValid = false;
                while (prompterMinMaxValid == false)
                {
                    Console.WriteLine("Choose a min and max interger?");
                    Console.WriteLine();
                    Console.Write("Enter a minimum number: ");
                    prompterMin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("Enter a maximum number: ");
                    prompterMax = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    if (prompterMin > prompterMax) { Console.WriteLine(); Console.WriteLine("Invalid, try again."); }
                    else if (prompterMin == prompterMax) { Console.WriteLine(); Console.WriteLine("Can't be the same number. Try again."); }
                    else { prompterMinMaxValid = true; }
                }
                while (prompterValid == false)
                {
                    Console.WriteLine("Select a number between " + prompterMin + " and " + prompterMax);
                    Console.WriteLine();
                    Console.WriteLine();
                    prompter = Convert.ToInt32(Console.ReadLine());
                    if ((prompter < prompterMin) || (prompter > prompterMax))
                    {
                        Console.WriteLine(prompter + " is not in between " + prompterMin + " and " + prompterMax);
                    }
                    else
                    {
                        Console.WriteLine("Good job, you did it, " + prompter + " is in between " + prompterMin + " and " + prompterMax);
                        prompterValid = true;
                    }
                }
                Console.ReadLine();
            }

            static void navPercentPassing()
            {
                bool scoreDone = false;
                string scoreInput;
                int numScore = 1;
                int numPassing = 0;
                double passingScore = 0;
                Console.WriteLine();
                while ((passingScore > 100) || (passingScore < 20))
                {
                    Console.Write("Enter multiple scores from 0% - 100%, what is the passing percentage?: %");
                    passingScore = Convert.ToDouble(Console.ReadLine());
                    if ((passingScore > 100) || (passingScore < 20)) { Console.WriteLine(); Console.WriteLine("Error, passing percentage must be in between 20% and 100%"); }
                }
                Console.WriteLine();
                Console.WriteLine("To stop entering scores type 'Done'. ");
                Console.WriteLine();
                while (scoreDone == false)
                {
                    Console.Write("Score number " + numScore + ": %");
                    scoreInput = Console.ReadLine();
                    if ((scoreInput == "Done") || (scoreInput == "done")) { scoreDone = true; }
                    else if (Convert.ToDouble(scoreInput) > 100 || (Convert.ToDouble(scoreInput) < 0))
                    {
                        Console.WriteLine("Invalid, scores must be from 0% to 100%");
                        Console.WriteLine();
                    }
                    else if (Convert.ToDouble(scoreInput) >= passingScore) { numPassing++; numScore++; }
                    else { numScore++; }
                }
                Console.WriteLine();
                Console.WriteLine(numPassing + "/" + (numScore - 1) + " people passed.");
                Console.ReadLine();
            }

            static void navOddSum()
            {
                int oddSum = 0;
                int oddSumDisplay = 0;
                int oddInput = 0;
                bool evenInput = true;
                while (evenInput ==true)
                {
                    Console.WriteLine();
                    Console.WriteLine("Odd Sum, enter an odd interger and learn the sum of all the odd numbers from 1 to your odd number.");
                    Console.WriteLine("Example, input: 7, (7 + 5 + 3 + 1)");
                    Console.WriteLine();
                    Console.Write("Enter a odd number: ");
                    oddInput = Convert.ToInt32(Console.ReadLine());
                    if (oddInput % 2 == 0) { Console.Clear(); Console.WriteLine("That was an even number, number must be odd."); }
                    else { evenInput = false; oddSumDisplay = oddInput; }
                }
                Console.WriteLine();
                for (int i = 1; i <= oddInput; i++) 
                {
                    Console.Write(oddSumDisplay) ;
                    if (i <= oddInput - 1) { Console.Write(" + "); }
                    oddInput -= 1;
                    oddSum += oddSumDisplay;
                    oddSumDisplay -= 2;
                }
                Console.WriteLine() ;
                Console.WriteLine("The sum of all these odd numbers is, " + oddSum) ;
                Console.ReadLine();

            }

            static void navRandomNum()
            {
                Random generator = new Random();
                int randMin;
                int randMax;
                Console.WriteLine();
                Console.WriteLine("Random number generator, 25 random numbers.");
                Console.Write("Random min: ");
                randMin = Convert.ToInt32(Console.ReadLine());
                Console.Write("Random max: ");
                randMax = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                for (int r = 1; r <= 25; r++)
                    {
                    Console.Write(" " + generator.Next(randMin, randMax + 1));
                    }
                Console.ReadLine() ;
            }

            string navigator = "";
            while (navigator != "0")
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Which Program would you like to run?");
                Console.WriteLine();
                Console.WriteLine("1 - Prompter");
                Console.WriteLine("2 - Percent Passing");
                Console.WriteLine("3 - Odd Sum");
                Console.WriteLine("4 - Random Numbers");
                Console.WriteLine("");
                Console.WriteLine("0 - Quit");
                Console.WriteLine();
                Console.Write("Enter the designated number:  ");
                navigator = Console.ReadLine();
                Console.WriteLine();
                Console.Clear();

                if (navigator == "1") { navPrompter(); }
                else if (navigator == "2") { navPercentPassing(); }
                else if (navigator == "3") { navOddSum(); }
                else if (navigator == "4") { navRandomNum(); }

                else if (navigator == "0") { Environment.Exit(0); }
                else { Console.WriteLine(); Console.WriteLine("Invalid Option. Click 'Enter' to try again."); Console.ReadLine(); }
            }
        }
    }
}