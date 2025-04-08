using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Database
{
    public class DbConnect : IDbConnect
    {
        private readonly string _connectionString;
        private readonly string _checkCMD;
        private readonly string _createCMD;

        public DbConnect(string connectionString, string checkCMD, string createCMD) 
        {
            _checkCMD = checkCMD;
            _connectionString = connectionString;
            _createCMD = createCMD;
        }
        public void DatabaseExist()
        {
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                sqlConnection.Open();
                Console.WriteLine("Connection opened successfully");

                using (SqlCommand sqlCommand = new SqlCommand(_checkCMD, sqlConnection))
                {
                    int exists = Convert.ToInt32(sqlCommand.ExecuteScalar() ?? 0);

                    if (exists > 0)
                    {
                        Console.WriteLine("Database already exists.");
                    }
                    else
                    {
                        using (SqlCommand createCommand = new SqlCommand(_createCMD, sqlConnection))
                        {
                            createCommand.ExecuteNonQuery();
                            Console.WriteLine("Database created successfully.");
                        }
                    }
                }
            }
        }

        public void GroupProduct()
        {
            throw new NotImplementedException();
        }

        public void InsertProduct()
        {
            throw new NotImplementedException();
        }
        public void CustomerProduct()
        {
            throw new NotImplementedException();
        }

    }
}
