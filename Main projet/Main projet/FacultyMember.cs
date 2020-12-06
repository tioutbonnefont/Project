using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_projet
{
    public class FacultyMember : User
    {
        public List<Course> courses = new List<Course>();



        public FacultyMember(List<Course> courses, int ID, string name, string password, string adress, string inscriptionDate, string phoneNumber) : base(ID, name, password, adress, inscriptionDate, phoneNumber)
        {
            this.courses = courses;
        }


        public double GradeAStudent(Student student)
        {
            double grade = 0;
            Console.WriteLine("Which grade would you assign to" + student);
            grade = Convert.ToInt32(Console.ReadLine());
            student.notes[0].Add(grade);
            return grade;
        }

        public void AttendThere(Student student)
        {
            bool attendance = true;
            student.Attendance.Add(attendance);
            Console.WriteLine(student.name + " is present.");
        }
        public void AttendAbsent(Student student)
        {
            bool attendance = false;
            student.Attendance.Add(attendance);
            Console.WriteLine(student.name + " is absent.");
        }

        public Exam CreateExam(string name, double duration, string coursePlan, FacultyMember prof, string room)  // method used to Create an Exam
        {
            Exam exam = new Exam(name, duration, coursePlan, prof, room, new List<Student>());  // here is the new Object Exam
            Console.WriteLine("This Exam as been created with succes"); // confirmation sentence
            return exam;
        }

        public void EditCoursePlan(Course course)
        {
            Console.WriteLine("There is the actual courseplan :");
            Console.WriteLine(course.CoursePlan);
            Console.WriteLine();
            Console.WriteLine("Type the new courseplan : ");
            course.CoursePlan = Console.ReadLine();
            Console.WriteLine("There is the new courseplan");
            Console.WriteLine(course.CoursePlan);
            Console.ReadKey();
        }



        public void ToString()
        {
            Console.WriteLine("Name : " + name + ", ID : " + ID + ", Inscription Date : " + inscriptionDate);
        }

    }
}
