using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class the_crossbar : Trainer
    {
        public bool НаличиеПерекладины { get; set; }
        public bool НаличиеБрусьев { get; set; }

        public override double РасчетЭнергопотребления()
        {
            // перекладина нуль 
            return 0;
        }
    }
}
