import java.util.Arrays;
import java.util.Scanner;

public class Input {
    public static int[] dimensionsReader() {
        return Arrays.stream(new Scanner(System.in).nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
    }

    public static String readString() {
        return new Scanner(System.in).nextLine();
    }

    public static int[] readStringToArray(String command) {
        return Arrays.stream(command.split(" ")).mapToInt(Integer::parseInt).toArray();
    }

    public static void assignValuesToMatrix(int[][] matrix, int value, int x, int y) {
        for (int i = 0; i < x; i++)
        {
            for (int j = 0; j < y; j++)
            {
                matrix[i][j] = value++;
            }
        }
    }
}
