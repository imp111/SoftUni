package StudentSystem;

public class Student {
    private String name;
    private Integer age;
    private Double grade;

    private String message;

    public String GetMessage() {
        return message;
    }

    public void SetMessage(String message) {
        this.message = message;
    }

    public String GetName() {
        return name;
    }

    public Integer GetAge() {
        return age;
    }

    public Double GetGrade() {
        return grade;
    }

    public Student(String command, String name, Integer age, Double grade) {
        if (command.toLowerCase().equals("create")) {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }
    }

    public Student() {

    }

    public void DisplayInformation(Student student) {
        if (student.GetGrade() >= 5.50) {
            student.SetMessage("Excellent student");
        }
        else if (student.GetGrade() >= 3.00) {
            student.SetMessage("Average student");
        }
        else {
            student.SetMessage("Very nice person");
        }

        System.out.printf("%s is %d years old. %s.\n" , student.GetName(), student.GetAge(), student.GetMessage());
    }
}
