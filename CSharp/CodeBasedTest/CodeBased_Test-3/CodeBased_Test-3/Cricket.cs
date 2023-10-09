using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBased_Test_3
{
    class Cricket
    {
        public void Pointscalculation(int no_of_matches)
        {
            int[] scores = new int[no_of_matches];

            Console.WriteLine("Enter the scores for each match");
            for (int i = 0; i < no_of_matches; i++)
            {
                scores[i] = Convert.ToInt32(Console.ReadLine());
            }
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            double average = (double)sum / no_of_matches;

            Console.WriteLine($"Sum of scores: {sum}");
            Console.WriteLine($"Average of scores: {average}");
            Console.Read();
        }

    }
    class program
    {
        static void Main()
        {
            Console.WriteLine("Enter the number of matches:");
            int numMatches = Convert.ToInt32(Console.ReadLine());

            Cricket cricket = new Cricket();
            cricket.Pointscalculation(numMatches);

        }
    }
    
}
