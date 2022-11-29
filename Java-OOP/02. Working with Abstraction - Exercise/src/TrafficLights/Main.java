package TrafficLights;

import java.util.ArrayList;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        String[] input = Input.ReadInput();
        Integer n = Input.ReadNumberOfOperations();
        List<TrafficLight> lightsList = new ArrayList<>();

        Output.AddLightsToList(input, lightsList);
        Output.PrintLightsList(n, lightsList);
    }
}
