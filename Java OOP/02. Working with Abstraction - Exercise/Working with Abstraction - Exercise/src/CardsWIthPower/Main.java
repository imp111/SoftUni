package CardsWIthPower;

import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        String rank = new Scanner(System.in).nextLine().toUpperCase();
        String suit = new Scanner(System.in).nextLine().toUpperCase();
        Card newCard = new Card();

        newCard.CalculateCard(rank, suit);
    }
}
