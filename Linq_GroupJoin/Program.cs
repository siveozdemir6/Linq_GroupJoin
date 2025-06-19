using Linq_GroupJoin;

List <Class> classes = new List<Class>
{
    new Class { ClassId = 1, ClassName = "Matematik"},
    new Class{ClassId =2, ClassName = "Türkçe"},
    new Class{ClassId = 3, ClassName = "Kimya"}
};

List<Student> students = new List<Student>
{
    new Student { StudentId = 1, ClassId = 1, StudentName = "Ali" },
    new Student { StudentId = 2, ClassId = 2, StudentName = "Ayşe" },
    new Student { StudentId = 3, ClassId = 1, StudentName = "Mehmet" },
    new Student { StudentId = 4, ClassId = 3, StudentName = "Fatma" },
    new Student { StudentId = 5, ClassId = 2, StudentName = "Ahmet" },
};


var groupJoin = from c in classes
                join s in students on c.ClassId equals s.ClassId into studentClasses
                select new
                {
                    c.ClassName,
                    Students = studentClasses,
                };
foreach(var group in groupJoin)
{
    Console.WriteLine("Sınıf: " + group.ClassName );

    foreach (var student in group.Students)
    {
        Console.WriteLine(" --- " + student.StudentName );
    }
}
