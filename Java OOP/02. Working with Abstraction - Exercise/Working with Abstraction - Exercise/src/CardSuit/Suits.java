package CardSuit;

public class Suits {

    public enum Suit {
        CLUBS(0),
        DIAMONDS(1),
        HEARTS(2),
        SPADES(3);

        private Integer suit;

        Suit(Integer suit) {
            this.suit = suit;
        }

        public Integer getSuit() {
            return suit;
        }
    }

    public void PrintSuits() {
        System.out.println("CardsWIthPower.Card CardSuit.Suits:");

        for (var item : Suit.values()) {
            System.out.printf("Ordinal value: %d; Name value: %s\n", item.getSuit(), item);
        }
    }
}
