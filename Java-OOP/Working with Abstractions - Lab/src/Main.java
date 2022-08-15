import java.util.Scanner;
import java.util.function.Predicate;

public class Main {
    public static void main(String[] args) {
        int input = readInput();
        String figure = buildFigure(input);
        printFigure(figure);
    }

    public static int readInput()
    {
        return Integer.parseInt(new Scanner(System.in).nextLine());
    }

    public static String buildFigure(int input)
    {
        return printRows(1, input, +1, input) + printRows(input - 1, 1, -1, input);
    }

    private static String printRows(int start, int end, int step, int size)
    {
        StringBuilder strBuilder = new StringBuilder();
        Predicate<Integer> loopCondition = iter -> {
          if (step > 0) {
              return iter <= end;
          }

          return iter >= end;
        };

        for (int i = start; loopCondition.test(i); i += step) {
            strBuilder.append(printLine(size - i, i)).append(System.lineSeparator());
        }

        return strBuilder.toString();
    }

    private static String printLine(int spaces, int stars)
    {
        StringBuilder out = new StringBuilder();
        
        for (int i = 0; i < spaces; i++) {
            out.append(" ");
        }

        for (int i = 0; i < stars; i++) {
            out.append("* ");
        }
        return out.toString();
    }

    public static void printFigure(String figure)
    {
        System.out.println(figure);
    }
}