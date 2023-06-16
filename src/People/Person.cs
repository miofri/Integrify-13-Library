using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.src
{
    public class Person
    {
        private System.Guid _id;
        public string _name;
        public string _address;

        public Person(string name, string address)
        {
            _id = new System.Guid();
            _name = name;
            _address = address;
        }
    }
}
