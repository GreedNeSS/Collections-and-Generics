using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection
{
    class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person firstPerson, Person lastPerson)
        {
            if (firstPerson?.Age > lastPerson?.Age)
            {
                return 1;
            }
            else if (firstPerson?.Age < lastPerson?.Age)
            {
                return -1;
            }
            return 0;
        }
    }
}
