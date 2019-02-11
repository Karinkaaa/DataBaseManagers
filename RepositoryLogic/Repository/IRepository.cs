using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLogic.Repository
{
   interface IRepository<T> where T : class
    {
        void Save(T obj);
        void Remove(T obj);
        void Remove(int idj);
        void Update(T objOld, T objNew);
        void Update(int id, T objNew );
        T GetFromID(int id);
        IList<T> GetAll();
        IList<T> Get(T template);
    }
}
