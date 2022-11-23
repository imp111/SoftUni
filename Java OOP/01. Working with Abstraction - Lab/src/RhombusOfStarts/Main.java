package RhombusOfStarts;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        int num = Input();
        FigureBuilder(num);
    }

    public static void FigureBuilder(int iterations) {
        for (int i = 1; i <= iterations; i++) {
            PrintRow(iterations, i);
        }

        for (int i = iterations - 1; i >= 1; i--) {
            PrintRow(iterations, i);
        }
    }

    public static Integer Input() {
        return new Scanner(System.in).nextInt();
    }

    public static void PrintRow(int size, int starCount) {
        for (int i = 0; i < size - starCount; i++) {
            System.out.print(" ");
        }

        for (int i = 1; i < starCount; i++) {
            System.out.print("* ");
        }

        System.out.println("*");
    }
}
