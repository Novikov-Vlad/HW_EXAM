using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EXAM
{
    public abstract class Animal
    {
        public string name { get; private set; }
        public int weight { get; private set; }
        public string families { get; private set; }//всм семейство кошачих или псовые
        public string sqade { get; private set; }//всм хищники или нет
        public int Colvo { get; private set; }//имеется ввиду сколько животных данного типа сейчас в вальере
        
        public Animal(string AnimalName, int AnimalWeight, string AnimalFamilies, string AnimalSqade, int AnimalColvo)
        {
            this.name = AnimalName;
            this.weight = AnimalWeight;
            this.families = AnimalFamilies;
            this.sqade = AnimalSqade;
            this.Colvo = AnimalColvo;
        }

        public abstract void TypeAnimal();
    }
}
