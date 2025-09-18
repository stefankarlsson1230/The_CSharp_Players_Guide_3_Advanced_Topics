// Student Grades - Compute average and order.

// 10 students from chatGPT
List<Student> students = new List<Student>
{
    new Student("Alice Johnson", 87),
    new Student("Brian Smith", 92),
    new Student("Carla Martinez", 76),
    new Student("David Lee", 84),
    new Student("Emma Brown", 95),
    new Student("Frank Wilson", 68),
    new Student("Grace Kim", 90),
    new Student("Henry Adams", 73),
    new Student("Isabella Clark", 81),
    new Student("Jack Turner", 88),
};


Console.WriteLine("All students");

foreach (Student student in students)
{
    Console.WriteLine(student);
}
Console.WriteLine();

double average = students.Average(s => s.grade);

IEnumerable<Student> orderedStudents = from s in students
                                       orderby s.grade descending
                                       select s;


Console.WriteLine("Average grade: " + average);
Console.WriteLine();

Console.WriteLine("Students ordered by grade");
foreach(Student student in orderedStudents)
{
    Console.WriteLine(student);
}



// Types
public record Student(string name, int grade)
{
    public override string ToString()
    {
        return $"Name: {name}  \tGrade: {grade}";
    }
}