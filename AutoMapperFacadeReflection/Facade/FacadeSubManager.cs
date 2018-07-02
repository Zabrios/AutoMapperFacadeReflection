using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMapperFacadeReflection
{
    public class FacadeSubManager
    {
        //private FacadeSub2.MonitorOff mo;
        //private FacadeSub2.ComputerOff co;
        //private FacadeSub1.ServicesOff so;
        //private FacadeSub1.WindowsOff wo;

        public void TurnOffEverything()
        {
            string subMonitor = FacadeSub2.MonitorOff.TurnOffMonitor();
            string subComputer = FacadeSub2.ComputerOff.TurnOffComputer();

            string subServices = FacadeSub1.ServicesOff.TurnServicesOff();
            string subWindows = FacadeSub1.WindowsOff.TurnWindowsOff();

            Console.WriteLine(string.Format(@"{0}{1}{2}{3}{4}{5}{6}", subMonitor, Environment.NewLine,
                subComputer, Environment.NewLine, subServices, Environment.NewLine, subWindows));
        }
    }
}
