using System;

using System.Collections;

using System.Collections.Generic;

using System.Linq;

using System.Text;

namespace StudentDatabase
{
    public abstract class Student
    {
        public string StudName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public long StudId { get; set; }
        public string Major { get; set; }
        public float GPA { get; set; }


          public Student(string studentName, DateTime dateOfBirth, long studId, string major, float gpa)

          {//Catherine McGovern, 491930
           
              StudName = studentName;
              DateOfBirth = dateOfBirth;
              StudId = studId;
              Major = major;
              GPA = gpa;

          }  

         

          public override string ToString() =>
                $"{StudName} {DateOfBirth} {StudId} {Major} {GPA}";

    }
}