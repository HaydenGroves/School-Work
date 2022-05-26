using System;
using AForge;
using AForge.Genetic;

namespace GAforAssignment
{
    class Program
    {
             

        static void Main(string[] args)
        {


            double Target = Validation();
            BinaryChromosome firstOne = new BinaryChromosome(16);
            HorizontalDistanceFunction fitnessFunction = new HorizontalDistanceFunction(Target);          
            EliteSelection selectionMethod = new EliteSelection();
            Population population = new Population(10,  
                firstOne,
                fitnessFunction,
                selectionMethod);
            
            int generationNumber = 0;
            while(true)
            {
                generationNumber++;
                population.RunEpoch();

                BinaryChromosome bestOne = population.BestChromosome as BinaryChromosome;
                double[] bestVals = fitnessFunction.Translate(bestOne);
                double range = (bestVals[0] * bestVals[0]) * (Math.Sin(2 * bestVals[1])) / 9.8;

                Console.WriteLine("Generation Number: " + generationNumber);
                Console.WriteLine("Initial Velocity: " + Math.Round(bestVals[0],3) + "m/s  Initial Angle: " + Math.Round(bestVals[1],3));
                Console.WriteLine("Best Horizontal Range: " + Math.Round(range,3) + "m");
                Console.WriteLine("Distance from Target: " + Math.Round((Target - range),3) + "m");
                

                if (Target - range < 1 && Target - range > 0)
                {
                    break;
                }
            }
            Console.ReadLine();
        }

        static double Validation()
        {
            double input = 0;
            while(true)
                {
                Console.WriteLine("Please enter the distance to the target in m");
                input = Convert.ToDouble(Console.ReadLine());

                if (input > 100)
                {
                    Console.WriteLine("The target is too far, it would be too dangerous to fire the cannon");
                }
                else if (input < 5)
                {
                    Console.WriteLine("The target is too close, it would be dangerous to fire the cannon");
                }
                else
                {
                    break;
                   
                }
            }
            return input;
        }
    }

    public class HorizontalDistanceFunction : OptimizationFunction2D
    {
        double Target;

        public HorizontalDistanceFunction(double target) : base(new AForge.Range(0, 100), new AForge.Range(0, 90))
        {
            Target = target;
        }

        public override double OptimizationFunction(double inital_velocity, double angle)
        {
            double horizontalDistance = (inital_velocity * inital_velocity) * (Math.Sin(2 * angle)) / 9.8;
            double difference = horizontalDistance - Target;
            if (difference < 0.0) difference = -difference;
            double fitness = 100 - difference;
            if (fitness < 0.0) fitness = 0;
            return fitness;
        }
    }
}
