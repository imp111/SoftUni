package CardSuit;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        String input = new Scanner(System.in).nextLine();

        if (input.toLowerCase().equals("card suits")) {
            Suits newSuit = new Suits();
            newSuit.PrintSuits();
        }
        else {
            System.out.println("Wrong input");
        }
    }
}