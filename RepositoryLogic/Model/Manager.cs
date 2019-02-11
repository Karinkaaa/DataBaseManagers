using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryLogic.Model
{
    public class Manager
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }

        public Manager() { }
        public Manager(string name, string surname, int age, string phone)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Phone = phone;
        }
    }
}
