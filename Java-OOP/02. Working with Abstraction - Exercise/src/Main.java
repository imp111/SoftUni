import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int[] dimestions = Input.dimensionsReader();
        int x = dimestions[0];
        int y = dimestions[1];

        int[][] matrix = new int[x][y];
        int value = 0;

        Input.assignValuesToMatrix(matrix, value, x, y);
        String command = Input.readString();

        long sum = 0;
        System.out.println(Output.mainFunction(command, matrix, sum));
    }
}
