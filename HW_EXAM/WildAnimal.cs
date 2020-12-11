using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EXAM
{
    public enum TypeWildAnimal { mammals, amphibian };//млекопитающие и земноводные
    public class WildAnimal : Animal
    {
        public TypeWildAnimal Wildtype;

        public WildAnimal(string WildName, int WildWeight, string WildFamilies, string WildSqade, int WildColvo, TypeWildAnimal Wildtype)
            : base(WildName, WildWeight, WildFamilies, WildSqade, WildColvo)
        {
            this.Wildtype = Wildtype;
        }
        public override void TypeAnimal()
        {
            Console.WriteLine(Wildtype.ToString());
        }
    }
}
