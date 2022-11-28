package CardsWIthPower;

public class Card {
    public enum Suit {
        CLUBS(0),
        DIAMONDS(13),
        HEARTS(26),
        SPADES(39);

        private Integer suit;

        Suit(Integer suit) {
            this.suit = suit;
        }

        public Integer getSuit() {
            return suit;
        }
    }

    public enum Rank {
        ACE(14),
        TWO(2),
        THREE(3),
        FOUR(4),
        FIVE(5),
        SIX(6),
        SEVEN(7),
        EIGHT(8),
        NINE(9),
        TEN(10),
        JACK(11),
        QUEEN(12),
        KING(13);

        private Integer rank;

        Rank(Integer rank) {
            this.rank = rank;
        }

        public Integer getRank() {
            return rank;
        }
    }

    public void CalculateCard(String power, String suit) {
        System.out.printf("CardsWIthPower.Card name: %s of %s; CardsWIthPower.Card power: %d", Rank.valueOf(power), Suit.valueOf(suit), (Rank.valueOf(power).getRank() + Suit.valueOf(suit).getSuit()));
    }
}
