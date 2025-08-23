using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
1. Non-static:
 * By default, class members are non-static.
 * A non-static member belongs to an object, not the class itself.
 * Its value can change based on the object (since classes are blueprints and objects contain the actual data).
 * Non-static fields are initialized every time a new object is created from the class.

2. Static:
 * The static keyword can be applied to methods, fields, or properties of a class.
 * A static member belongs to the class itself, not to any object, and cannot be accessed through an object.
 * It is shared among all objects of the class.
 * Static fields are initialized once when the class is loaded into memory, not each time an object is created.
*/


namespace c_.Basic_Concepts
{
    class Student
    {
        // Non-static field (belongs to each object separately) because each student has his own name
        public string Name;

        // Static field (shared by all objects) because all students is in the same school
        public static string SchoolName = "School";

        // Non-static method because each student has his own info
        public void ShowInfo()
        {
            Console.WriteLine($"{Name} studies at {SchoolName}");
        }

        // Static method because school name is related to all students so it is for the class not objects
        public static void ChangeSchool(string newSchool)
        {
            SchoolName = newSchool;
            Console.WriteLine($"School changed to: {SchoolName}");
        }
    }


    class StaticAndNonStatic
    {
        public static void DemoStaticVsNonStatic()
        {
            // Create two students (objects)
            Student s1 = new Student();
            s1.Name = "Seif";

            Student s2 = new Student();
            s2.Name = "Tokhy";

            s1.ShowInfo();
            s2.ShowInfo();  

            // Change the static SchoolName (affects ALL students)
            Student.ChangeSchool("We School");

            // Now both students reflect the new static value
            s1.ShowInfo();  
            s2.ShowInfo();
        }

    }
}
