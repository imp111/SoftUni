public class TrafficLight {
    private String stateOne;
    private String stateTwo;
    private String stateThree;

    public String getStateThree() {
        return stateThree;
    }

    public String getStateTwo() {
        return stateTwo;
    }

    public String getStateOne() {
        return stateOne;
    }

    public TrafficLight(String stateOne, String stateTwo, String stateThree) {
        this.stateOne = stateOne;
        this.stateTwo = stateTwo;
        this.stateThree = stateThree;
    }

    public void Operation(Integer numberOfOperations) {
        for (int i = 0; i < numberOfOperations; i++) {
            
        }
    }
}
