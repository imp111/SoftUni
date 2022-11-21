package PointInRecrangle;

public class Main {
    public static void main(String[] args) {
        int[] rectanglePointReader = Reader.RectangleReader();
        Rectangle rectangle = new Rectangle(rectanglePointReader[0], rectanglePointReader[1], rectanglePointReader[2], rectanglePointReader[3]);

        int numberOfIterations = Reader.IterationsReader();
        Printer.Print(numberOfIterations, rectangle);
    }
}