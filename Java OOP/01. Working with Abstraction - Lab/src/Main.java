import java.util.Arrays;
import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        String[] input = Input.Reader();

        PriceCalculator newPriceCalculator = new PriceCalculator(Double.parseDouble(input[0]), Integer.parseInt(input[1]));
        newPriceCalculator.TotalPriceCalculation(input[2].toUpperCase(), input[3].toUpperCase());
    }
}
