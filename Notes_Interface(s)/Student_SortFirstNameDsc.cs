using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Interface_s_
{
    internal class Student_SortFirstNameDsc : IComparer<Student>
    {
        int IComparer<Student>.Compare(Student x, Student y)
        {
            return x.FirstName.CompareTo(y.FirstName) * -1;
        }
    }
}
