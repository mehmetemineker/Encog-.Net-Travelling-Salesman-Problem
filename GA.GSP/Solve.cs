using Encog.ML.EA.Population;
using Encog.ML.EA.Species;
using Encog.ML.EA.Train;
using Encog.ML.Genetic.Crossover;
using Encog.ML.Genetic.Genome;
using Encog.ML.Genetic.Mutate;
using Encog.Neural.Networks.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA.GSP
{
    public class Solve
    {
        private int cityCount;

        public int CityCount
        {
            get { return cityCount; }
            set { cityCount = value; }
        }

        private int mapHeight;
        private int mapWidth;
        private int populationSize = 1000;
        private int maxSameSolition = 50;
        private TrainEA genetic;

        public City[] cities;

        public Solve(int cityCount, int mapHeight, int mapWidth)
        {
            this.cityCount = cityCount;
            this.mapHeight = mapHeight;
            this.mapWidth = mapWidth;
        }

        public void RandomFirstCities()
        {
            cities = new City[cityCount];

            Random rnd = new Random();

            for (int i = 0; i < cities.Length; i++)
            {
                int xPos = (int)(rnd.NextDouble() * mapWidth);
                int yPos = (int)(rnd.NextDouble() * mapHeight);

                cities[i] = new City(xPos, yPos);
            }
        }

        private IntegerArrayGenome RandomGenome()
        {
            IntegerArrayGenome result = new IntegerArrayGenome(cities.Length);
            int[] organism = result.Data;
            bool[] taken = new bool[cities.Length];

            Random rnd = new Random();

            for (int i = 0; i < organism.Length - 1; i++)
            {
                int icandidate;
                do
                {
                    icandidate = (int)(rnd.NextDouble() * organism.Length);
                } while (taken[icandidate]);

                organism[i] = icandidate;
                taken[icandidate] = true;

                if (i == organism.Length - 2)
                {
                    icandidate = 0;
                    while (taken[icandidate])
                    {
                        icandidate++;
                    }
                    organism[i + 1] = icandidate;
                }
            }
            return result;
        }

        private BasicPopulation InitPopulation()
        {
            BasicPopulation result = new BasicPopulation(populationSize, null);

            BasicSpecies defaultSpecies = new BasicSpecies()
            {
                Population = result
            };

            for (int i = 0; i < populationSize; i++)
            {
                IntegerArrayGenome genome = RandomGenome();
                defaultSpecies.Members.Add(genome);
            }

            result.GenomeFactory = new IntegerArrayGenomeFactory(cities.Length);
            result.Species.Add(defaultSpecies);

            return result;
        }

        public int[] Run()
        {
            StringBuilder builder = new StringBuilder();

            IPopulation pop = InitPopulation();


            ICalculateScore score = new FitnessFunction(cities);

            genetic = new TrainEA(pop, score);

            genetic.AddOperation(0.9, new SpliceNoRepeat(cityCount / 3));
            genetic.AddOperation(0.1, new MutateShuffle());

            int sameSolutionCount = 0;
            int iteration = 1;
            double lastSolution = Double.MaxValue;

            while (sameSolutionCount < maxSameSolition)
            {
                genetic.Iteration();

                double thisSolution = genetic.Error;

                builder.Length = 0;
                builder.Append("Iteration: ");
                builder.Append(iteration++);
                builder.Append(", Best Path Length = ");
                builder.Append(thisSolution);

                Console.WriteLine(builder.ToString());

                if (Math.Abs(lastSolution - thisSolution) < 1.0)
                {
                    sameSolutionCount++;
                }
                else
                {
                    sameSolutionCount = 0;
                }

                lastSolution = thisSolution;
            }

            Console.WriteLine("Good solution found:");

            IntegerArrayGenome best = (IntegerArrayGenome)genetic.BestGenome;

            
            genetic.FinishTraining();


            return best.Data;
        }

    }
}
