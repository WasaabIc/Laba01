using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class RunRoad : Trainer
    {
        public double ДлинаПолотна { get; set; }
        public List<string> СписокРежимов { get; set; }

        public override double РасчетЭнергопотребления()
        {
            // override я предоставляю свой расчет потребления , а беговая дорожка будет у нас 100 , конкретики в задание не было 
            return 100;
        }

    }
}
