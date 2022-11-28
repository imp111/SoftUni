using test;

string[] input = Console.ReadLine().Split().ToArray();
List<Student> students = new List<Student>();

while (input[0].ToLower() != "exit")
{
    if (input.Length == 4)
    {
        students.Add(new Student(input[1], int.Parse(input[2]), double.Parse(input[3])));
    }
    else if (input.Length == 2)
    {
        Student searchedStudent = SearchStudent(students, input[1]);
        searchedStudent.DisplayInformation(searchedStudent);
        
    }
    else
    {

    }
}


static Student? SearchStudent(List<Student> students, string name)
{
    foreach (var student in students)
    {
        if (student.Name == name)
        {
            return student;
        }
    }

    return null;
}