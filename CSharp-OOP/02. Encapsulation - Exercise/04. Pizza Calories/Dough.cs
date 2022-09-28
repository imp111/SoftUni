using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Pizza_Calories
{
    internal class Dough
    {
        private string type;
        private string flour;
        private string technique;
        private double weight;
        private double flourModifier;
        private double techniqueModifier;
        private double doughCalories;

        public Dough(string type, string flour, string technique, double weight)
        {
            Type = type;
            Flour = flour;
            Technique = technique;
            Weight = weight;
        }

        public double CalorieCount()
        {
            switch (flour.ToLower())
            {
                case "white":
                    flourModifier = 1.5;
                    break;
                case "wholegrain":
                    flourModifier = 1.0;
                    break;
                default:
                    break;
            }

            switch (technique.ToLower())
            {
                case "crispy":
                    techniqueModifier = 0.9;
                    break;
                case "chewy":
                    techniqueModifier = 1.1;
                    break;
                case "homemade":
                    techniqueModifier = 1.0;
                    break;
                default:
                    break;
            }

            doughCalories = (2 * Weight) * flourModifier * techniqueModifier;
            return doughCalories;
        }

        public string Type
        {
            get
            {
                return type;
            }
            set
            {
                if (value.ToLower() != "dough")
                {
                    throw new Exception("Invalid type.");
                }

                type = value;
            }
        }

        public string Flour
        {
            get
            {
                return flour;
            }
            set
            {
                if (value.ToLower() != "wholegrain" && value.ToLower() != "white")
                {
                    throw new Exception("Invalid type of dough.");
                }

                flour = value;
            }

        }

        public string Technique
        {
            get
            {
                return technique;
            }
            set
            {
                if (value.ToLower() != "crispy" && value.ToLower() != "chewy" && value.ToLower() != "homemade")
                {
                    throw new Exception("Invalid baking technique.");
                }

                technique = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 200 || value < 0)
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
                }

                weight = value;
            }
        }
    }
}
