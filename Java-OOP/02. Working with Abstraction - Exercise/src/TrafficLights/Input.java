package TrafficLights;

import java.util.Arrays;
import java.util.Scanner;

public class Input {
    public static String[] ReadInput() {
        return (String[]) Arrays.stream(new Scanner(System.in)
                .nextLine()
                .toUpperCase()
                .split("\\s+"))
                .toArray(String[]::new);
    }

    public static Integer ReadNumberOfOperations() {
        return new Scanner(System.in).nextInt();
    }
}
