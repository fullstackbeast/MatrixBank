using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBMS.Models.Entities;

namespace MyBMS.Interface.Service
{
    public interface IManagerService
    {
        public Manager AddManager(Manager manager);
        public Manager GetManager(int id);
        public Manager GetManagerByEmail(string email);

        public void DeleteManager(int id);

        public List<Manager> GetAll();

        public Manager UpdateManager(Manager manager);

    }
}
