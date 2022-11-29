public class Output {
    public static long mainFunction(String command, int[][] matrix, long sum) {
        while (!command.equalsIgnoreCase("let the force be with you"))
        {
            int[] ivoS = Input.readStringToArray(command);
            int[] evil = Input.dimensionsReader();
            int xE = evil[0];
            int yE = evil[1];

            while (xE >= 0 && yE >= 0)
            {
                if (xE >= 0 && xE < matrix.length && yE >= 0 && yE < matrix[0].length)
                {
                    matrix[xE][yE] = 0;
                }
                xE--;
                yE--;
            }

            int xI = ivoS[0];
            int yI = ivoS[1];

            while (xI >= 0 && yI < matrix[1].length)
            {
                if (xI >= 0 && xI < matrix.length && yI >= 0 && yI < matrix[0].length)
                {
                    sum += matrix[xI][yI];
                }

                yI++;
                xI--;
            }

            command = Input.readString();
        }

        return sum;
    }
}
