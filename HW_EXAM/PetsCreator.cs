using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EXAM
{
    public class PetsCreator : Creator
    {
        public override Animal zooMethod(string PetsName, int PetsWeight, string PetsFamilies, string PetsSqade, int PetsColvo, TypePetsAnimal PetsType)
        {
            return new PetsAnimal(PetsName, PetsWeight, PetsFamilies, PetsSqade, PetsColvo, PetsType);
        }

        public override Animal zooMethod(string WildName, int WildWeight, string WildFamilies, string WildSqade, int WildColvo, TypeWildAnimal Wildtype)
        {
            throw new NotImplementedException();
        }

    }
}
