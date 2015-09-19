using AbstractFactory.Repositories;
using AbstractFactory.Repositories.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories.Factories
{
    public class SqlRepositoryFactory : IRepositoryFactory
    {
        public IRoomRepository CreateRoomRepositoryFactory()
        {
            return new SqlRoomRepository(ConfigurationManager.ConnectionStrings["ConnectToSQL"].ConnectionString);
        }
    }
}
