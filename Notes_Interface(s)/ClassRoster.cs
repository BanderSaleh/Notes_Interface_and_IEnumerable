using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Interface_s_
{
    // IEnumerable
    internal class ClassRoster : IEnumerable
    {
        // Field to store our main global accessable list data
        int[] arr;
        List<Student> _classList;

        // Constructor
        public ClassRoster()
        {
            // Defined a new instance of _classList when the ClassRoster() code segment gets used
            _classList = new List<Student>();
        }

        internal List<Student> ClassList { get => _classList; }
        
        public void AddStudent(Student student)
        {
            _classList.Add(student);
        }

        // Important section of code the MainWindow.xaml.cs IEnumerator requires from this .cs page
        //because that's going to be the thing that tells you how to work through the MainWindow's forloop
        public IEnumerator GetEnumerator()
        {
            //throw new NotImplementedException();
            return new ClassRosterEnumerator(ref _classList); //Directs the code to this method below where we define index value to start a foreach 
        }
        

        private class ClassRosterEnumerator : IEnumerator
        {
            // Field to keep track of our index, declare with -1
            int index = -1;
            List<Student> students;

            // Make sure to take a list of your type, and put REF before it
            //REF keyword specifying it is an address in memory
            public ClassRosterEnumerator(ref List<Student> studentList)
            {
                students = studentList;
            }
            // Returns the current item in the list at the index
            //public object Current => throw new NotImplementedException();
            public object Current => students[index];

            public bool MoveNext()
            {
                //throw new NotImplementedException();

                // Increase the Index
                index++;
                // If it is pass the last item in the list, return false, else return true
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
