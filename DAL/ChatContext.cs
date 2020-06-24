using System.Data.Entity;
using ChatService.Models;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace ChatService.DAL
{
    [DbConfigurationType(typeof(MySqlConfiguration))]
    public class ChatContext : DbContext
    {

        public DbSet<Chat> Chat { get; set; }
        public ChatContext() : base("DefaultConnection")
        {

        }

        public ChatContext(DbConnection existingConnection, bool contextOwnsConnection)
          : base(existingConnection, contextOwnsConnection)
        {

        }
    }


   /* public class Conn
    {
        public Conn()
        {
            string connectionString = "server=localhost;port=3305;database=chat_dev;user=dev;password=qasw";

            using (var conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                using (var context = new ChatContext(conn, false))
                {
                }
            }
        }
    } 
    }*/

}