using Student_LabTask;

Console.WriteLine("1. Add a new student.\r\n2. Add an exam for the student\r\n3. Check the exam Score\r\n4. Show the exam list\r\n5. Show the student's average score\r\n6. Delete the exam\r\n0. Finish the proccess");

Console.WriteLine("Press a number to continue: ");

Student student = new();
List<Student> students = new List<Student>();
List<Student> exams = new List<Student>();


int MenuButton=int.Parse(Console.ReadLine());

switch (MenuButton)
{
    case 0:
        break;
        break;
    case 1:
        student.FullName = Console.ReadLine();
        students.Add(student);
        break;
    case 2:
        int no = int.Parse(Console.ReadLine());
        if (student.No == no)
        {
            student.examName = Console.ReadLine();
            student.point = int.Parse(Console.ReadLine());
            student.AddExam(student.examName, student.point);
            exams.Add(student);
        }
        break;
    case 3:
        int no1 = int.Parse(Console.ReadLine());
        string examName = Console.ReadLine();
        if (student.No == no1 && student.examName == examName)
        {
            Console.WriteLine();
        }
        break;
}