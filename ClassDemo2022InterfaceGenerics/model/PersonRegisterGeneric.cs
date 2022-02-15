using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2022InterfaceGenerics.model
{
    public class PersonRegisterGeneric<T> // sætter at den kan tage forskellige typer
    {
        private List<T> _list;

        public PersonRegisterGeneric()
        {
            _list = new List<T>();
        }

        public List<T> GetAll()
        {
            return new List<T>(_list);
        }

        public T Add(T p)
        {
            _list.Add(p);
            return p;
        }

        public T Delete(T p)
        {
            _list.Remove(p);
            return p;
        }


        public override string ToString()
        {
            return $"Liste : {string.Join(", ", _list)}";
        }
    }
}
