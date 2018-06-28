using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine(string.Format(@"{0}---- AutoMapper test -----{1}", Environment.NewLine, Environment.NewLine));
            var autoMapperTest = new AutoMapperTest();
            autoMapperTest.MappingTest();
        }
    }

    
}
