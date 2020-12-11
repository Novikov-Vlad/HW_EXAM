using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_EXAM
{
    public static class Extencion
    {
        public static void ShowItems(this IZOO zoo)
        {
            Console.WriteLine("Загон для животных: ");
            foreach (var i in zoo.Items)
            {
                Console.WriteLine("Животное: {0}, Вес животного: {1}, Семейство: {2}, Отряд:{3}, Количество:{4}", 
                    i.name, i.weight, i.families, i.sqade, i.Colvo);
            }
        }
    }
}
