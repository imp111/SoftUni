import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        String[] input = Input.ReadInput();
        Integer n = Input.ReadNumberOfOperations();
        List<TrafficLight> lightsList = new ArrayList<>();

        for (int i = 0; i < input.length; i++) {
            TrafficLight light = new TrafficLight(Colors.valueOf(input[i]));
            lightsList.add(light);
        }

        for (int i = 0; i < n; i++) {
            for (TrafficLight light : lightsList) {
                light.changeColor();
                System.out.print(light.getColor() + " ");
            }

            System.out.println();
        }
    }
}
