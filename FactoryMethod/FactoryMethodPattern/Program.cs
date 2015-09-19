using FactoryMethodPattern.Developer;
using FactoryMethodPattern.House;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            OneDeveloper dev;
            OneHouse house;
            Console.WriteLine("Enter type house:\n\n 1-Panel house\n 2-Wood house\n");
            int typeHouse = Convert.ToInt32(Console.ReadLine());
            switch (typeHouse)
            {
                case 1:
                    dev = new PanelDeveloper("Ltd. Rivbud");
                    house = dev.Create();
                    Console.WriteLine("Build company: {0}", dev.Name);
                    break;
                case 2:
                    dev = new WoodDeveloper("Ltd. Rivnepromekobud");
                    house = dev.Create();
                    Console.WriteLine("Build company: {0}", dev.Name);
                    break;
                default:
                    Console.WriteLine("Incorrect choice");
                    break;
            }

            Console.ReadLine();
        }
    }
}
