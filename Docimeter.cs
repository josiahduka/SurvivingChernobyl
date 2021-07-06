using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SurvivingChernobyl
{
    class Docimeter
    {
        public double CPM;
        public double REM;

        public Docimeter() //base dose
        {
            CPM = 30;
            REM = .1;
            //call different methods to add to doseage
        }
        public void OfficeDose(Docimeter dose)
        {
            CPM += 10;
            REM += .3;
            Console.WriteLine($"CPM: {CPM}\nREM: {REM}");
            
        }
        public void WinDose(Docimeter dose)
        {
            CPM -= 30 ;
            REM += 95.0;
            Console.WriteLine($"CPM: {CPM}\nREM: {REM}");

        }

    }
}
