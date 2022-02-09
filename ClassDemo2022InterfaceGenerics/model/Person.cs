using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo2022InterfaceGenerics.model
{
    public class Person
    {
        private int _id;
        private String _name;
        private String _adr;

        public Person()
        {
        }

        public Person(int id, string name, string adr)
        {
            _id = id;
            _name = name;
            _adr = adr;
        }

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Adr
        {
            get => _adr;
            set => _adr = value;
        }

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Adr)}: {Adr}";
        }
    }
}
