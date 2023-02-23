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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Notes_Interface_s_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        /* Didn't call my studentList here because it's very public
        List<Student> studentList = new List<Student>();
        */

        ClassRoster prog124 = new ClassRoster();
        public MainWindow()
        {
            // The classes in this project are inspired
            //by the new Harry Potter game
            InitializeComponent();
            /*
            Door door = new Door();
            Bottle bottle = new Bottle();
            Chest chest = new Chest();

            List<IOpen> openableItems = new List<IOpen>();
            openableItems.Add(door);
            openableItems.Add(bottle);
            openableItems.Add(chest);
            openableItems[0].Open();
            */
            //Student student = new Student("Dylan", "Register", 100, 100);
            //studentList.Add(new Student("Dylan", "Register", 100, 100));
            //lbStudents.Items.Add(student); 
            Preload();
            // Add each instance of Student on each row in our Listbox
            DisplayStudents();



        
        }

        // IEnumberable
        //finish writing the code for these below

        public void 
        public void Preload()...
        public void InterfaceExample()...
        
            
        private void lbStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
