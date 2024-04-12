using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateDBOracle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================================== Create database ACS ========================================");
            using (var dbContext = new CreateDBOracle.DataContextModel.Model12())
            {
                // Kiểm tra và tạo cơ sở dữ liệu nếu cần
                dbContext.Database.CreateIfNotExists();
                Console.WriteLine("Database ACS has been created or updated successfully.");
            }
            Console.WriteLine("======================================== Create database ACS success ========================================");
        }
    }
}
