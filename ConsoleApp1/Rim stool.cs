using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rim_stool : Trainer
    {
        public double Наклон { get; set; }
        public double[] Размеры { get; set; }

        public override double РасчетЭнергопотребления()
        {
            // квадратные скобочки ну я массив под размеры ( там 100.50.123.666) , а римскийс стул работает без электричества, ну мог 
            // быть просто электрический стул 
            return 0;
        }

    }
}
