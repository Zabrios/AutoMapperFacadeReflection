using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperFacadeReflection
{
    public class ReflectionElephantModel
    {
        public string ScientificName { get; set; }
        public double Weight { get; set; }
        public int Height { get; set; }

        public ReflectionElephantModel()
        {

        }

        public ReflectionElephantModel(string ScientificName, double Weight, int Height)
        {
            this.ScientificName = ScientificName;
            this.Weight = Weight;
            this.Height = Height;
        }
    }


}
