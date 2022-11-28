import java.util.Arrays;
import java.util.Scanner;

public class Input {
    public static String[] ReadInput() {
        return (String[]) Arrays.stream(new Scanner(System.in)
                .nextLine().split(" ")).toArray(String[]::new);
    }

    public static Integer ReadNumberOfOperations() {
        return new Scanner(System.in).nextInt();
    }
}
