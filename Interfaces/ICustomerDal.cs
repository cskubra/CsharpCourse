using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();

    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql updated!");
        }

        public void Update()
        {
            Console.WriteLine("Sql deleted!");
        }
    }

    class OracleDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle updated!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle deleted!");
        }
    }

    class MysqlDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Mysql added!");
        }

        public void Delete()
        {
            Console.WriteLine("Mysql updated!");
        }

        public void Update()
        {
            Console.WriteLine("Mysql deleted!");
        }
    }

    class CustomerManager
    {
        public void Add(ICustomerDal customerDal)
        {
            customerDal.Add();
        }

    }
}
