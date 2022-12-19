using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Student_LabTask
{
    public class Student
    {
        private static int _no;
        public int No { get; set; }
        public string FullName { get; set; }
        public string examName { get; set; }
        public int point { get; set; }

        Dictionary<string, int> Exam;

        List<Student> students=new List<Student>();

        static Student()
        {
            _no = 0;
        }
        public Student()
        {
            _no++;
            No = _no;
        }

        public void AddExam(string examName, int point)
        {
            if (examName != null)
            {
               Exam.Add(examName, point);
            }
        }

        public void GetExamResult(string examName)
        {

            while (Exam.ContainsKey(examName))
            {
                foreach (var item in Exam)
                {
                    Console.WriteLine($"{point}");
                }
            }
        }
        public static double GetExamAvg(List<Student> students)
        {
            return students.Average(st=>st.point);
        }       
    }
}
