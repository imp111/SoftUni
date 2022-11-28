public class TrafficLight {
    private Colors color;
    public Colors getColor() {
        return color;
    }
    public TrafficLight(Colors color) {
        this.color = color;
    }
    public void changeColor() {
        switch (this.color) {
            case RED -> this.color = Colors.GREEN;
            case YELLOW -> this.color = Colors.RED;
            case GREEN -> this.color = Colors.YELLOW;
            default -> {
            }
        }
    }
}