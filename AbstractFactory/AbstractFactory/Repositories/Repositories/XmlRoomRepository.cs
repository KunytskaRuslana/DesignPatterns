using AbstractFactory.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AbstractFactory.Repositories.Repositories
{
    public class XmlRoomRepository : IRoomRepository
    {
        #region IRoomRepository

        public List<Room> SelectAll()
        {
            List<Room> rooms;
            using (FileStream fs2 = new FileStream("XmlHotelUkraine.xml", FileMode.OpenOrCreate))
            {
                XmlSerializer f2 = new XmlSerializer(typeof(List<Room>));
                rooms = (List<Room>)f2.Deserialize(fs2);
            }
            return rooms;
        }
        #endregion
    }
}
