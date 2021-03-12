using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBMS.Interface.Repository;
using MyBMS.Interface.Service;
using MyBMS.Models.Entities;

namespace MyBMS.Domain.Service
{
    public class ManagerService : IManagerService
    {
        private readonly IManagerRepository _managerRepository;


        public ManagerService(IManagerRepository managerRepository)
        {
            _managerRepository = managerRepository;
    
        }

        public Manager AddManager(Manager manager)
        {
            Manager mn = _managerRepository.AddAccountManager(manager);
           
            return mn;
        }


        public void DeleteManager(int id)
        {
            _managerRepository.DeleteManager(id);
        }

        public List<Manager> GetAll()
        {
            return _managerRepository.GetAll();
        }

        public Manager GetManager(int id)
        {
            return _managerRepository.GetManager(id);
        }

        public Manager GetManagerByEmail(string email)
        {
            return _managerRepository.FindByEmail(email);
        }

        public Manager UpdateManager(Manager manager)
        {
            return _managerRepository.UpdateManager(manager);
        }
    }
}
