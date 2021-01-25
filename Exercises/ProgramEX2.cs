using System;

namespace ProgEx2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nPart 1, sum 10 numbers.");
            int sum = SumTenInts(0, 0);
            char letterGrade = 'X';
            Console.WriteLine($"The sum of ten integers is {sum}");

            Console.WriteLine("\nPart 2, average 10 numbers.");
            double avg = AvgTenInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg);
            Console.WriteLine($"The average of ten integers is {avg} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart 3, average user predetermined number of scores.");
            Console.WriteLine("How many scores do you wish to enter?");
            string noScores = Console.ReadLine();
            int numScores = int.Parse(noScores);
            double avg1 = AvgUnkInts(0, 0, numScores);
            letterGrade = ConvertNumericToLetterGrade(avg1);
            Console.WriteLine($"The average of {numScores} integers is {avg1} and the letter grade is {letterGrade}");

            Console.WriteLine("\nPart 4, average non predetermined number of scores.");
            double avg2 = AvgAnyInts(0, 0);
            letterGrade = ConvertNumericToLetterGrade(avg2);
            Console.WriteLine($"The average of listed integers is {avg2} and the letter grade is {letterGrade}");

        }
          

        private static char ConvertNumericToLetterGrade(double grade)
        {
            if (grade > 90)
                return 'A';
            else if (grade > 80)
                return 'B';
            else if (grade > 70)
                return 'C';
            else if (grade > 60)
                return 'D';
            else
                return 'F';
        }

        private static double AvgAnyInts(int sum, int count)
        {
            Console.WriteLine("Enter a score: ");
            string input = Console.ReadLine();
            if (int.Parse(input) == -1)
                return sum / count;
            else
            {
                sum += int.Parse(input);
                return AvgAnyInts(sum, count + 1);
            }
                
        }
        

        private static double AvgUnkInts(int sum, int count, int numScores)
        {
            
            Console.WriteLine("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            if (count < numScores)
                return AvgUnkInts(sum, count + 1, numScores);
            else
                return sum/count;
        }
        private static double AvgTenInts(int sum, int count)
        {
            Console.WriteLine("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            if (count < 10)
                return AvgTenInts(sum, count + 1);
            else
                return sum/count;
        }

        private static int SumTenInts(int sum, int count)
        {
            Console.WriteLine("Enter a score: ");
            string input = Console.ReadLine();
            sum += int.Parse(input);
            if (count < 10)
                return SumTenInts(sum, count + 1);
            else
                return sum; 
        }
    }

}



