using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EXAM
{
    public abstract class Creator
    {
        public abstract Animal zooMethod(string WildName, int WildWeight, string WildFamilies, string WildSqade, int WildColvo, TypeWildAnimal Wildtype);

        public abstract Animal zooMethod(string WildName, int WildWeight, string WildFamilies, string WildSqade, int WildColvo, TypePetsAnimal PetsType);
    }
}
