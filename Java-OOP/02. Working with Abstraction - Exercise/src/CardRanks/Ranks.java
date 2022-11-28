package CardRanks;

public class Ranks {

    public enum Rank {
        ACE(0),
        ONE(1),
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

    public void PrintSuits() {
        System.out.println("CardsWIthPower.Card CardSuit.Suits:");

        for (var item : Rank.values()) {
            System.out.printf("Ordinal value: %d; Name value: %s\n", item.getRank(), item);
        }
    }
}
