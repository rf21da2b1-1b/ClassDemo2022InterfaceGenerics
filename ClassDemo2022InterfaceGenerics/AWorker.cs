using System;
using ClassDemo2022InterfaceGenerics.model;

namespace ClassDemo2022InterfaceGenerics
{
    public class AWorker
    {
        public AWorker()
        {
        }

        public void Start()
        {
            IRegister register = new PersonRegister();
            register.Add(new Person(3000, "peter", "22334455"));
            register.Add(new Person(5000, "jakob", "33445566"));
            register.Add(new Person(6000, "charlotte", "22334477"));

            foreach (Person p in register.GetAll())
            {
                Console.WriteLine(p);
            }


            Console.WriteLine(register);

        }
    }
}