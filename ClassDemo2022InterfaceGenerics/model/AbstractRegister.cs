using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2022InterfaceGenerics.model
{
    public abstract class AbstractRegister : IRegister
    {
        // attribut -- protected dvs. kan ses i klassen (private) + nedarvede klasser (protected)
        protected List<Person> _liste;

        public AbstractRegister()
        {
            _liste = new List<Person>();
        }

        public List<Person> GetAll()
        {
            return new List<Person>(_liste);
        }

        public abstract Person Add(Person person);
    }
}
