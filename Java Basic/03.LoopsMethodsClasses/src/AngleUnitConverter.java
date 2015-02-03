import java.util.Scanner;

/**
 * Angle Unit Converter (Degrees ↔ Radians)
 * Write a method to convert from degrees to radians.
 * Write a method to convert from radians to degrees.
 * You are given a number n and n queries for conversion.
 * Each conversion query will consist of a number
 * + space + measure. Measures are "deg" and "rad".
 * Convert all radians to degrees and all degrees to radians.
 * Print the results as n lines, each holding a number +
 * space + measure. Format all numbers with 6 digit
 * after the decimal point.
 */

public class AngleUnitConverter {

    static void convertInput(Scanner s, int lines, String[] out) {
        for (int i = 0; i < lines; i++) {
            String[] command = s.nextLine().split(" ");
            double value = Double.parseDouble(command[0]);
            String arg = command[1];

            if (arg.equals("rad"))
                out[i] = "" + String.format("%.6f", Math.toDegrees(value)) + " deg";
            if (arg.equals("deg"))
                out[i] = "" + String.format("%.6f", Math.toRadians(value)) + " rad";
        }
    }

    private static void printResults(String[] results) {
        for (String r : results)
            System.out.println(r);
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        int n = in.nextInt();
        in.nextLine();
        String[] results = new String[n];

        convertInput(in, n, results);
        printResults(results);
    }
}
