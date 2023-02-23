using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Interface_s_
{
    internal class Student : IComparable<Student>
    {
        // Fields
        string _firstName;
        string _lastName;
        double _csiGrade;
        double _genEdGrade;

        // Constructor
        public Student(string firstName, string lastName)
        {
            Random rand = new Random(); // Defined an Instance of Random
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = rand.Next(0, 101);
            _genEdGrade = rand.Next(0, 101);
        }

        // Instance
        //created a new Instance
        //team_SortDsc sortTeamDesc = new team_SortDsc();

        public string FirstName { get => _firstName; set => _firstName = value; }
        public string LastName { get => _lastName; set => _lastName = value; }
        public double CsiGrade { get => _csiGrade; set => _csiGrade = value; }
        public double GenEdGrade { get => _genEdGrade; set => _genEdGrade = value; }

        // Icompareable
        //compares objects in lists to return different organization
        public int CompareTo(Student other)
        {
            if (_csiGrade < other._csiGrade) return 1;
            else if (_csiGrade > other._csiGrade) return -1;
            else return 0;
        }

        // Override
        public override string ToString()
        {
            // return this string
            return $"{_firstName} {_lastName} - CSI Grade {_csiGrade} -  Gen Ed Grade - {GenEdGrade}";
        }


    }
}
