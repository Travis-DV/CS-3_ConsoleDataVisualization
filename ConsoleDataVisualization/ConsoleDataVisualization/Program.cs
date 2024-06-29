using System;
using Validator;
using Utilitys;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleDataVisualization
{
    class Program
    {
        public static void Main(string[] args)
        {
            int numberOfPoints;
            int[] data = new int[1];

            int OneOrTwo = Validator.Validator.OneOrTwo("Enter Data", "Use Random Data", "Do you want to");

            if (OneOrTwo == 1)
            {
                data = Validator.Validator.GetIntArray("Enter Data");
            }
            else if (OneOrTwo == 2)
            {
                numberOfPoints = Validator.Validator.GetInt("How many data points do you want?");
                data = new int[numberOfPoints];
                for (int i = 0; i < numberOfPoints; i++)
                {
                    data[i] = RandomNumber.Between();
                }
            }

            GenerateBarChart(data);
        }

        public static void GenerateBarChart(int[] input)
        {
            foreach (int item in input)
            {
                Console.Write($"{item.ToString()}: ");
                Console.WriteLine("".PadLeft(item, '#'));
            }
        }
    }
}

