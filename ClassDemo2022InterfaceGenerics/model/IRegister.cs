using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2022InterfaceGenerics.model
{
    public interface IRegister
    {
        // definerer kun metodernes navn, returværdi + parametre -- ingen kode
        public List<Person> GetAll();

        public Person Add(Person person);
    }
}
