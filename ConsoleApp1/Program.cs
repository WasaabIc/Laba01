using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba1 
{
    class Program
    {
        static void Main(string[] args)
        {
            ТренажерныйЗал тренажерныйЗал = new ТренажерныйЗал
            {
                Тренажеры = new List<Trainer>
            {
                new RunRoad(),
                new bike_trainer(),
                new bench(),
                new Rim_stool(),
                new the_crossbar()
            }
            };
            // в этой программе я сделал вывод общее энерго потребление 

            Console.WriteLine("Общее энергопотребление тренажеров в зале: " + тренажерныйЗал.РасчетОбщегоЭнергопотребления());
        }
    }


}
