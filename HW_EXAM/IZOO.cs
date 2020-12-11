using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EXAM
{
    public interface IZOO
    {
        IEnumerable<Animal> Items { get; }
        void Add(Animal animals);
        int ColvoType();
        void Sort();
        IEnumerable<Animal> FindAnimalByFamily(string s);

    }
}
