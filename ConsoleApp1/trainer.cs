using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Trainer
    {
        public string ТипНагрузки { get; set; }
        public double МассаТренажера { get; set; }
        public double НапряжениеЭлектросети { get; set; }

        // abstract class я взял потому что буду туда наследовать все свои тренажеры , а расчет энергопотребление потому что 
        // в нем тоже будут много тренажеров , считать надо ему 
        public abstract double РасчетЭнергопотребления();
    }
}
