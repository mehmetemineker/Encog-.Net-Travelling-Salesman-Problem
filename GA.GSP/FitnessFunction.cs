using Encog.Neural.Networks.Training;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encog.ML;
using Encog.ML.Genetic.Genome;

namespace GA.GSP
{
    public class FitnessFunction : ICalculateScore
    {
        private City[] cities;

        public FitnessFunction(City[] cities)
        {
            this.cities = cities;
        }

        public bool ShouldMinimize => true;

        public bool RequireSingleThreaded => false;

        public double CalculateScore(IMLMethod network)
        {
            double result = 0.0;
            IntegerArrayGenome genome = (IntegerArrayGenome)network;
            int[] path = genome.Data;

            for (int i = 0; i < cities.Length - 1; i++)
            {
                City city1 = cities[path[i]];
                City city2 = cities[path[i + 1]];

                double dist = city1.Proximity(city2);
                result += dist;
            }

            return result;
        }
    }
}
