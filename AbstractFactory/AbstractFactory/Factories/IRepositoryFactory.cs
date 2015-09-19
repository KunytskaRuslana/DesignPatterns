using AbstractFactory.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public interface IRepositoryFactory
    {
        IRoomRepository CreateRoomRepositoryFactory();
    }
}
