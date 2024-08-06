using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_O_programming
{
    internal class User
    {
        internal string Fname;
        internal string Lname;
        internal int Age;

        internal User()
        {

        }

        internal User(string firstname, string lastname, int age)
        {
            Fname = firstname;
            Lname = lastname;   
            Age = age;
        }

        internal bool isRetired()
        {
            return (Age >= 66);
        }

    }
}
