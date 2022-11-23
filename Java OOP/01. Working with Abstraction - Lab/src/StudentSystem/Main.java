package StudentSystem;

import java.util.*;

public class Main {
    public static void main(String[] args) {
        String[] input = Input.Input();
        List<Student> studentList = new ArrayList<>();

        while (!input[0].toLowerCase().equals("exit")) {
            if (input.length == 4) {
                studentList.add(new Student(input[0], input[1], Integer.parseInt(input[2]), Double.parseDouble(input[3])));
            }
            else if (input.length == 2) {
                Student student = FindStudent(studentList, input[1]);
                student.DisplayInformation(student);
            }

            input = Input.Input();
        }
    }

    public static Student FindStudent(List<Student> studentList, String name) {
        for (Student student : studentList) {
            if (student.GetName().equals(name)) {
                return student;
            }
        }
        return null;
    }
}
