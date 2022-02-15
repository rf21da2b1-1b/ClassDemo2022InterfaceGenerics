using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2022InterfaceGenerics.model
{
    public class PersonRegister : AbstractRegister
    {
        public override Person Add(Person person)
        {
            _liste.Add(person);
            return person;
        }

        public override string ToString()
        {
            return $"List [ {String.Join(',', _liste)} ]";
        }
    }
}
