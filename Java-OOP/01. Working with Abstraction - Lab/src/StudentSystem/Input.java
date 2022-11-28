package StudentSystem;

import java.util.Arrays;
import java.util.Scanner;

public class Input {
    public static String[] Input() {
        return (String[]) Arrays.stream(new Scanner(System.in)
                        .nextLine()
                        .split(" "))
                        .toArray(String[]::new);
    }

    public static void Printer(String output) {
        System.out.println(output);
    }
}
