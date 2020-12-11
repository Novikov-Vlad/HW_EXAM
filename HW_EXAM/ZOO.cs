using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EXAM
{
    public class ZOO : IZOO
    {
        private ICollection<Animal> items;

        public ZOO()
        {
            items = new List<Animal>();
        }

        public void Add(Animal animals)
        {
            items.Add(animals);
        }

        public int ColvoType()
        {
            return items.Sum(x => x.Colvo);
        }

        public void Sort()
        {
            var temp = items.OrderBy(x => x.Colvo).ToList();
            items.Clear();
            foreach(var item in temp)
            {
                items.Add(item);
            }    
        }

        public IEnumerable<Animal> FindAnimalByFamily(string s) // переменная s имеется ввиду первая буква sqade
        {
            return items.Where(x => (x.families == s)).ToList(); 
        }

        public IEnumerable<Animal> Items
        {
            get { return this.items; }
        }



    }
}
