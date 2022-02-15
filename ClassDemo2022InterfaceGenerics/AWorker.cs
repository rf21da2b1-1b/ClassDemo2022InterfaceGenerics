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
            /*
            IRegister register = new PersonRegister();
            register.Add(new Person(3000, "peter", "22334455"));
            register.Add(new Person(5000, "jakob", "33445566"));
            register.Add(new Person(6000, "charlotte", "22334477"));

            foreach (Person p in register.GetAll())
            {
                Console.WriteLine(p);
            }


            Console.WriteLine(register);
            */

            PersonRegisterGeneric<Person> reg = new PersonRegisterGeneric<Person>();
            reg.Add(new Person(3000, "peter", "22334455"));
            reg.Add(new Person(5000, "jakob", "33445566"));
            reg.Add(new Person(6000, "charlotte", "22334477"));

            Console.WriteLine(reg);

            PersonRegisterGeneric<String> reg2 = new PersonRegisterGeneric<String>();
            reg2.Add("peter");
            reg2.Add("jakob");
            reg2.Add("charlotte");

            Console.WriteLine(reg2);
        }
    }
}