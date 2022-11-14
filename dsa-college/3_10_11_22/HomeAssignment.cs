using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsa_college._10_11_22
{
    public class HomeAssignment
    {
        Student student;
        Lecturer lecturer;
        int grade = -1;

        public HomeAssignment(Student student)
        {
            this.student = student;
            

        }

        public Student getApplyingStudent() => student;
        public Lecturer getCheckingLecturer() => lecturer;

        public void setApplyingStudent(Student ptr) => student = ptr;

        public void setGrade(int grade) => this.grade = grade;

        public int getGrade() => grade;

        public void setCheckingLecturer(Lecturer ptr) => lecturer = ptr;
    }
}
