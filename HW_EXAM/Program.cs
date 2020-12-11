using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EXAM
{
    class Program
    {
        public static void Main(string[] args)
        {
            Creator[] creators = new Creator[2];
            creators[0] = new WildCreator();
            creators[1] = new PetsCreator();

            IZOO zoo = new ZOO();

            foreach(Creator i in creators)
            {
                if(i is WildCreator)
                {
                    zoo.Add(i.zooMethod("Волк", 40, "Собачьи", "Хищное", 3, TypeWildAnimal.mammals));
                    zoo.Add(i.zooMethod("Змея", 1, "змеиные", "Хищное", 2, TypeWildAnimal.amphibian));
                }
                if(i is PetsCreator)
                {
                    zoo.Add(i.zooMethod("Собака", 30, "Собачьи", "Хищное", 1, TypePetsAnimal.mammals));
                    zoo.Add(i.zooMethod("Кот", 10, "Кошачьи", "Хищное", 3, TypePetsAnimal.mammals));
                }
            }
          
            zoo.Sort();
            zoo.ShowItems();
            Console.WriteLine();
            Console.WriteLine("Колличество животных: {0}", zoo.ColvoType());
            Console.WriteLine("_____________________________________________________________________________");
            foreach(var items in zoo.FindAnimalByFamily("Собачьи"))
            {
                Console.WriteLine("Животное: {0}, Семейство: {1}", items.name, items.families);
            }

            Console.ReadKey();
        }
    }
}
