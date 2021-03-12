using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BMSEFDB.Models;
using MyBMS.Interface.Repository;
using MyBMS.Models.Entities;

namespace MyBMS.Domain.Repository
{
    public class ManagerRepository : IManagerRepository
    {
        private readonly BankDBContext _context;

        public ManagerRepository(BankDBContext context)
        {
            _context = context;

        }

        public Manager AddAccountManager(Manager manager)
        {
            _context.Managers.Add(manager);
            _context.SaveChanges();
            return manager;
        }

        public int CreateManager(Manager manager)
        {
            try
            {
                _context.Managers.Add(manager);
                _context.SaveChanges();
                return manager.Id;


            }
            catch (Exception ea)
            {
                Console.WriteLine($"err2: {ea.Message}");
            }



            return 0;
        }

        public void DeleteManager(int id)
        {
            var manager = _context.Managers.Find(id);
            _context.Remove(manager);
            _context.SaveChanges();
        }

        public Manager FindByEmail(string email)
        {
            return _context.Managers.FirstOrDefault(e => e.Email == email);
        }

        public Manager FindById(int id)
        {
            return _context.Managers.FirstOrDefault(i => i.Id == id);
        }

        public List<Manager> GetAll()
        {
            return _context.Managers.ToList();
        }

     

        public Manager GetManager(int id)
        {
            return _context.Managers.Find(id);
        }

        public Manager Update(Manager manager)
        {
            _context.Managers.Update(manager);
            _context.SaveChanges();
            return manager;
        }

        public Manager UpdateManager(Manager manager)
        {
            _context.Managers.Update(manager);
            _context.SaveChanges();
            return manager;
        }
    }
}
