using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EXAM
{
    public class WildCreator : Creator
    {
        public override Animal zooMethod(string WildName, int WildWeight, string WildFamilies, string WildSqade, int WildColvo, TypeWildAnimal Wildtype)
        {
            return new WildAnimal(WildName, WildWeight, WildFamilies, WildSqade, WildColvo, Wildtype);
        }

        public override Animal zooMethod(string WildName, int WildWeight, string WildFamilies, string WildSqade, int WildColvo, TypePetsAnimal PetsType)
        {
            throw new NotImplementedException();
        }
    }
}
