using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a jagged array to store student scores
        int[][] studentScores = new int[3][];

            // Initialize the jagged array with scores
            studentScores[0] = new int[] { 85, 92, 78 };
            studentScores[1] = new int[] { 90, 87, 93, 89 };
            studentScores[2] = new int[] { 76, 88 };

            // Print the scores of each student
            for (int i = 0; i < studentScores.Length; i++)
            {
                Console.Write("Student {0} scores: ", i + 1);

                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write(studentScores[i][j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            // Calculate and print the average score for each student
            for (int i = 0; i < studentScores.Length; i++)
            {
                double sum = 0;

                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }

                double average = sum / studentScores[i].Length;

                Console.WriteLine("Average score for student {0}: {1}", i + 1, average);
            }

            Console.WriteLine();

            // Calculate and print the average score for all students combined
            double totalSum = 0;
            int totalScores = 0;

            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalScores++;
                }
            }

            double totalAverage = totalSum / totalScores;

            Console.WriteLine("Average score for all students combined: {0}", totalAverage);
            Console.ReadLine();
        }
    }
    }

