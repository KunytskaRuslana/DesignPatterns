using AbstractFactory.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Repositories
{
    public interface IRoomRepository
    {
        List<Room> SelectAll();
    }
}
