public class Printer {
    public static void Print(int numberOfIterations, Rectangle rectangle) {
        for (int i = 0; i < numberOfIterations; i++) {
            int[] pointReader = Reader.PointReader();
            System.out.println(rectangle.Contains(new Point(pointReader[0], pointReader[1])));
        }
    }
}
