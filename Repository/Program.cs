using Repository.Repository;
using RepositoryLogic.Model;
using RepositoryLogic.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            var manager = new Manager("Roma", "Mihin", 22, "+380951234567");

            ManagerRepository repository = new ManagerRepository();


            
        }
    }
}
