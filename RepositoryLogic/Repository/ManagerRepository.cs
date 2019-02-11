using RepositoryLogic.Context;
using RepositoryLogic.Model;
using RepositoryLogic.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repository
{
    public class ManagerRepository : IRepository<Manager>
    {
        public DB_Managers DB { get; set; }

        public ManagerRepository()
        {
            this.DB = new DB_Managers();
        }

        public IList<Manager> GetAll()
        {
            return this.DB.Managers.ToList();
        }

        public IList<Manager> Get(Manager template)
        {
            return this.DB.Managers.Where(x => x.ID == template.ID).ToList();
        }

        public Manager GetFromID(int id)
        {
            return this.DB.Managers.Where(x => x.ID == id).FirstOrDefault();
        }

        public void Remove(Manager obj)
        {
            this.DB.Managers.Remove(this.DB.Managers.Where(x => x.ID == obj.ID).Select(x => x).FirstOrDefault());
            this.DB.SaveChanges();
        }

        public void Remove(int id)
        {
            this.DB.Managers.Remove(this.DB.Managers.Where(x => x.ID == id).FirstOrDefault());
            this.DB.SaveChanges();
        }

        public void Save(Manager obj)
        {
            this.DB.Managers.Add(obj);
            this.DB.SaveChanges();
        }

        public void Update(Manager objOld, Manager objNew)
        {
            this.DB.Managers.Remove(this.DB.Managers.Where(x => x.ID == objOld.ID).FirstOrDefault());
            this.DB.Managers.Add(objNew);
            this.DB.SaveChanges();
        }

        public void Update(int id, Manager objNew)
        {
            this.DB.Managers.Remove(this.DB.Managers.Where(x => x.ID == id).FirstOrDefault());
            this.DB.Managers.Add(objNew);
            this.DB.SaveChanges();
        }
    }
}
