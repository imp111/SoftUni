import java.util.Arrays;
import java.util.Scanner;

public class Input {
    public static String[] Reader() {
        return Arrays.stream(new Scanner(System.in)
                        .nextLine()
                        .split(" "))
                        .toArray(String[]::new);
    }
}
