package TrafficLights;

import java.util.List;

public class Output {
    public static void AddLightsToList(String[] input, List<TrafficLight> lightsList) {
        for (String s : input) {
            TrafficLight light = new TrafficLight(Colors.valueOf(s));
            lightsList.add(light);
        }
    }

    public static void PrintLightsList(Integer n, List<TrafficLight> lightsList) {
        for (int i = 0; i < n; i++) {
            for (TrafficLight light : lightsList) {
                light.changeColor();
                System.out.print(light.getColor() + " ");
            }

            System.out.println();
        }
    }
}
