import java.text.DecimalFormat;

public class PriceCalculator {
    private Double pricePerDay;
    private Integer numberOfDays;

    public Double GetPricePerDay() {
        return pricePerDay;
    }

    public Integer GetNumberOfDays() {
        return numberOfDays;
    }

    public enum Seasons {
        SPRING(2),
        SUMMER(4),
        AUTUMN(1),
        WINTER(3);

        private Integer multiplierBySeason;
        Seasons(Integer multiplier) {
            this.multiplierBySeason = multiplier;
        }

        public Integer getMultiplierBySeason() {
            return multiplierBySeason;
        }
    }

    public enum Discount {
        VIP(0.20),
        SECONDVISIT(0.10),
        NONE(0.0);

        private Double multiplierByDiscount;
        Discount(Double multiplier) {
            this.multiplierByDiscount = multiplier;
        }

        public Double getMultiplierByDiscount() {
            return multiplierByDiscount;
        }
    }

    public PriceCalculator(Double pricePerDay, Integer numberOfDays) {
        if (pricePerDay >= 0.01 && pricePerDay <= 1000.00) {
            this.pricePerDay = pricePerDay;
        }

        if (numberOfDays >= 1 && numberOfDays <= 1000) {
            this.numberOfDays = numberOfDays;
        }
    }

    public void TotalPriceCalculation(String season, String discount) {
        double discountPrice = GetPricePerDay() * GetNumberOfDays() * Seasons.valueOf(season).getMultiplierBySeason() * Discount.valueOf(discount).getMultiplierByDiscount();
        Double totalPrice = GetPricePerDay() * GetNumberOfDays() * Seasons.valueOf(season).getMultiplierBySeason() - discountPrice;
        System.out.print(String.format("%.2f", totalPrice));
    }
}
