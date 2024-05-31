using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class bench : Trainer
    {
        public double МаксимальныйВесПользователя { get; set; }
        public double Наклон { get; set; }

        public override double РасчетЭнергопотребления()
        {
            // Здесь будет ноль т.к скамейка у нас работает без электричества 
            return 0;
        }

    }
}
