using AbstractFactory.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Repositories.Repositories
{
    public class FakeRoomRepository : IRoomRepository
    {
        public List<Room> SelectAll()
        {
            List<Room> rooms = new List<Room>();
            rooms.Add(new Room() { Id = 1, Name = "Стандарт одномісний", Price = 592 });
            rooms.Add(new Room() { Id = 2, Name = "Стандарт двомісний", Price = 642 });
            rooms.Add(new Room() { Id = 3, Name = "Стандарт двомісний", Price = 662 });
            rooms.Add(new Room() { Id = 4, Name = "Напівлюкс", Price = 1102 });
            rooms.Add(new Room() { Id = 5, Name = "Напівлюкс покращений", Price = 1302 });
            rooms.Add(new Room() { Id = 6, Name = "Люкс", Price = 1602 });
            rooms.Add(new Room() { Id = 7, Name = "Люкс покращений", Price = 2902 });

            return rooms;
        }
    }
}
