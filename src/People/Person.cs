using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagement.src
{
    public abstract class Person
    {
        protected System.Guid _id;
        protected string _name;
        protected string _address;

        public Person(string name, string address)
        {
            _id = new System.Guid();
            _name = name;
            _address = address;
        }

        public string GetName
        {
            get { return _name; }
        }

        public System.Guid GetId
        {
            get { return _id; }
            set { _id = value; }
        }
    }
}
