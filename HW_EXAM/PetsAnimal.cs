using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EXAM
{
    public enum TypePetsAnimal { mammals, amphibian };//млекопитающие и земноводные
    public class PetsAnimal : Animal
    {
        public TypePetsAnimal PetsType;
        public PetsAnimal(string PetsName, int PetsWeight, string PetsFamilies, string PetsSqade, int PetsColvo, TypePetsAnimal PetsType)
            : base ( PetsName, PetsWeight, PetsFamilies, PetsSqade, PetsColvo)
        {
            this.PetsType = PetsType;
        }

        public override void TypeAnimal()
        {
            Console.WriteLine(PetsType.ToString());
        }
    }
}
