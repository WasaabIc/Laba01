using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     public class bike_trainer : Trainer
    {
        public List<string> СписокРежимов { get; set; }

        public override double РасчетЭнергопотребления()
        {
            
            return 80;
        }

    }
}
