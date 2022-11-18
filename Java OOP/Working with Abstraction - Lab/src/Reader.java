import java.util.Arrays;
import java.util.Scanner;

public class Reader {

    public static int[] RectangleReader() {
          return Arrays.stream(new Scanner(System.in)
                  .nextLine()
                  .split(" "))
                  .mapToInt(Integer::parseInt)
                  .toArray();
    }

    public static int[] PointReader() {
        return Arrays.stream(new Scanner(System.in)
                        .nextLine()
                        .split(" "))
                        .mapToInt(Integer::parseInt)
                        .toArray();
    }

    public static int IterationsReader() {
        return new Scanner(System.in)
                .nextInt();
    }
}
