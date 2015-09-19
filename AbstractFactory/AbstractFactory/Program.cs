using AbstractFactory.Entity;
using AbstractFactory.Factories;
using AbstractFactory.Factories.Factories;
using AbstractFactory.Repositories;
using AbstractFactory.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static IRoomRepository rooms;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter type repository: \n1.Sql Repository \n2.Xml Repository \n3.Fake Repository\n");
            int numRepository = Convert.ToInt32(Console.ReadLine());
            SqlRepositoryFactory roomSql = new SqlRepositoryFactory();
            XmlRepositoryFactory roomXml = new XmlRepositoryFactory();
            FakeRepositoryFactory roomFake = new FakeRepositoryFactory();

            switch (numRepository)
            {
                case 1:
                    Console.WriteLine("\nSQL Repository");
                    rooms = roomSql.CreateRoomRepositoryFactory();
                    break;
                case 2:
                    Console.WriteLine("\nXML Repository");
                    rooms = roomXml.CreateRoomRepositoryFactory();
                    break;
                case 3:
                    Console.WriteLine("\nFake Repository");
                    rooms = roomFake.CreateRoomRepositoryFactory();
                    break;
                default:
                    Console.WriteLine("Error");
                    break;
            }

            List<Room> room = new List<Room>();
            room = rooms.SelectAll();
            ShowList(room);

            Console.ReadKey();
        }

        public static void ShowList(List<Room> rooms)
        {
            for (int i = 0; i < rooms.Count; i++)
            {
                Console.WriteLine(String.Format("{0} {1} {2}", rooms[i].Id, rooms[i].Name, rooms[i].Price));
            }
        }
    }
}
