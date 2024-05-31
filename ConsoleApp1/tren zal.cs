using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ТренажерныйЗал
    {
        public List<Trainer> Тренажеры { get; set; }

        public ТренажерныйЗал()
        {
            Тренажеры = new List<Trainer>();
        }

        public double РасчетОбщегоЭнергопотребления()
        {
            double общееЭнергопотребление = 0;
            foreach (Trainer trainer in Тренажеры)
            {
                общееЭнергопотребление += trainer.РасчетЭнергопотребления();
            }
            return общееЭнергопотребление;
        }
    }


}
