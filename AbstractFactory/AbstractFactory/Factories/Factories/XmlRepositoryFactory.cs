using AbstractFactory.Repositories;
using AbstractFactory.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories.Factories
{
    public class XmlRepositoryFactory : IRepositoryFactory
    {
        public IRoomRepository CreateRoomRepositoryFactory()
        {
            return new XmlRoomRepository();
        }
    }
}
