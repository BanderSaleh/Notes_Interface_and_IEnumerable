using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_Interface_s_
{
    internal class Student
    {
        // Fields
        string _firstName;
        string _lastName;
        double _csiGrade;
        double _genEdGrade;

        // Constructor
        public Student(string firstName, string lastName, double csiGrade, double genEdGrade)
        {
            _firstName = firstName;
            _lastName = lastName;
            _csiGrade = csiGrade;
            _genEdGrade = genEdGrade;
        }

        // Instance
        //created a new Instance
        team_SortDsc sortTeamDesc = new team_SortDsc();
        
        // Icompareable
        //compares objects in lists to return different organization
        
    }
}
