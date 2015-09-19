using AbstractFactory.Entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Repositories.Repositories
{
    public class SqlRoomRepository : IRoomRepository
    {
        #region Queries

        private const string querySelect = "SELECT [dbo].[tblDescriptionRoom].[Id], [dbo].[tblTypeRooms].[Name], [dbo].[tblDescriptionRoom].[Price]"
                           + "FROM [dbo].[tblTypeRooms]"
                           + "JOIN [dbo].[tblDescriptionRoom] ON [dbo].[tblDescriptionRoom].[TypeRoomId] = [dbo].[tblTypeRooms].[Id]";

        #endregion


        #region Fileds

        private readonly string _connectionString;

        #endregion

        #region Constructors

        public SqlRoomRepository(string connectionString)
        {
            this._connectionString = connectionString;
        }

        #endregion

        #region IRoomRepository

        public List<Room> SelectAll()
        {
            using (SqlConnection connection = new SqlConnection(this._connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(querySelect, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        List<Room> room = new List<Room>();
                        while (reader.Read())
                        {
                            room.Add(new Room()
                            {
                                Id = (int)reader["id"],
                                Name = (string)reader["Name"],
                                Price = (int)reader["Price"]
                            });
                        }
                        return room;
                    }
                }
            }
        }

        //IRoomRepository CreateRoomRepository()
        //{
 
        //}
        #endregion
    }
}
