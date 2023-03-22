package RhombusOfStars;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        Integer n = scanner.nextInt();

        for (int i = 1; i <= n; i++) {
            printRow(n, i);
        }

        for (int i = n - 1; i >= 1; i--) {
            printRow(n, i);
        }
    }

    public static void printRow(Integer count, Integer starCount) {
        for (int i = 0; i < count - starCount; i++) {
            System.out.print(" ");
        }

        for (int i = 1; i < starCount; i++) {
            System.out.print("* ");
        }
        System.out.println("*");
    }
}