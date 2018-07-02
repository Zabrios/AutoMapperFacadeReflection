using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperFacadeReflection
{
    public class MainClass
    {
        public static void Main()
        {
            Console.WriteLine(string.Format(@"---- Facade test -----{0}", Environment.NewLine));
            FacadeSubManager fsm = new FacadeSubManager();
            fsm.TurnOffEverything();
            Console.WriteLine($@"{Environment.NewLine}---- AutoMap

per test -----{Environment.NewLine}");
            var autoMapperTest = new AutoMapperTest();
            autoMapperTest.MappingTest();

            Console.WriteLine(string.Format(@"{0}---- Reflection test -----{1}", Environment.NewLine, Environment.NewLine));

            Reflection.ReflectionManager xpr = new Reflection.ReflectionManager();
            xpr.XPathReader();

            Assembly assembly = typeof(MainClass).Assembly;
            Type elephantType = assembly.GetType("AutoMapperFacadeReflection.ReflectionElephantModel");
            var elephant = Activator.CreateInstance(elephantType, "Loxodonta africana", 7650, 396);
            Console.WriteLine(string.Format(@"{0}, {1}, {2}", ((ReflectionElephantModel)elephant).ScientificName, ((ReflectionElephantModel)elephant).Weight, ((ReflectionElephantModel)elephant).Height));
        }
    }


}
