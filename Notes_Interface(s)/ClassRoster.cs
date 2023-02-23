using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Interface_s_
{
    internal class ClassRoster: IEnumerable
    {
        // Field to store our main global accessable list data
        List<Student> _classList;

        // Constructor
        public ClassRoster()
        {
            // Defined a new instance of _classList when the ClassRoster() code segment gets used
            _classList = new List<Student>();
        }

        internal List<Student> ClassList { get => _classList; }
        
        //missing code here?
        
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }


        private class ClassRosterEnumerator : IEnumerator
        {
            // Field to keep track of our index
            int index = -1;
            List<Student> students;

            // Make sure to take a list of your type, and put REF before it
            public ClassRosterEnumerator(ref List<Student> studentList)
            {


            }

            // Returns the current item in the list at the index
            //public object Current => throw new NotImplementedException();
            public object Current => students[index];

            public bool MoveNext()
            {
                //throw new NotImplementedException();

                // Increase the Index
                index++;
                // If it is pass the last item in the list at the index
                if(index >= students.Count)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            // Sets index back to negative one
            public void Reset()
            {
                //throw new NotImplementedException();

                // Resets the index back to the default -1 value
                index = -1;
            
            }

        }



    }
}
