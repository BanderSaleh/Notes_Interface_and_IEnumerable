using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Notes_Interface_s_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow
    {
        //Didn't want to call my studentList here because it's very public
        List<Student> studentList = new List<Student>();
        ClassRoster prog124 = new ClassRoster();


        public MainWindow()
        {
            // The C# .cs classes in this project were inspired by Hogwarts Legacy
            InitializeComponent(); // Initialize this window of our project

            //Student_SortGenEdGrade grade = new Student_SortGenEdGrade(Student_SortGenEdGrade.Order.Descending);
            //students.Sort(grade);
            //studentList.Sort(grade);
            Student_SortGenEdGrade grade = new Student_SortGenEdGrade(Student_SortGenEdGrade.Order.Descending);
            
            // Run our Method to Add each instance of Student to each row in our Listbox
            DisplayStudents();
            // Creating preloaded data in this location is lazy, so we create a method and call it to run here
            Preload();

        }

        // IEnumberable
        //every time you hear that something has IEnumerable on it it's literally
        //the code that foreach uses to know how it's going to actually go through something
        //because on it's own it wouldn't know.

        /*
what I enumerable does is it says when I give you an object, if it's in a foreach and I give you something (containing innumerable), you have some kind of collection associated with you and you are going to provide the code that tells
me how to Loop through it. This is what that interface is doing: you're promising me you're going to give
me the materials I need to work with your collection.
        
So what we did in our class rosters is we said "IEnumerable" this was me saying
yes I promise you you'll have that the only thing you need is this GetEnumerator() because that's going to be the
thing that tells you how to work through it, but then we had to Define that; so by creating our IEnumerator here(ClassRoster.cs)
we declared our index, declared our list, synced them up; and then these three magic pieces of code right here: (inside ClassRoster.cs)
public object Current => students[index]; //Returns the current student it's looking at
public bool MoveNext() //Moves to the next item
public void Reset() //then also resets.
Because of all that ^ we can just pass in the program 124 we're good. We could do it again now, we could do class roster prog122...
        */

        // IEnumberable
        public void DisplayStudents()
        {
            // clear any previous data inside listbox
            lbStudents.Items.Clear();
            // forloop to return each instance of Student student in studentList.
            // foreach is a reason we use IEnumerable
            foreach (Student student in prog124.ClassList) // without .ClassList it doesn't know what i'm talking about
            {
                //add the instance of Student student to lbStudents
                lbStudents.Items.Add(student);
            }
        }

        public void Preload()
        {
            // created preloaded data to test our listbox wpf for our app.
            prog124.AddStudent(new Student("Will", "Cram"));
            prog124.AddStudent(new Student("Anne", "Nguyen"));
            prog124.AddStudent(new Student("Hannah", "Angel"));
            prog124.AddStudent(new Student("Kristyn", "Taniguchi"));

        }

        private void lbStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private string GetDebuggerDisplay()
        {
            return this.ToString();
        }







        //public void InterfaceExample()...

        /*  
        private void lbStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        */
    }
}
