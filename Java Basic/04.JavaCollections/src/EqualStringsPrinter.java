import java.util.HashSet;
import java.util.Scanner;

/**
 * Problem 2. Sequences of Equal Strings
 * Write a program that enters an array of strings and finds in
 * it all sequences of equal elements. The input strings
 * are given as a single line, separated by a space.
 */

public class EqualStringsPrinter {
    static void printEqualElements(String[] arr) {
        HashSet<String> checked = new HashSet<>();

        for (int i = 0; i < arr.length; i++) {
            String current = arr[i];
            if (checked.contains(current)) continue;
            checked.add(current);
            System.out.print(current + " ");

            for (int j = 0; j < arr.length; j++) {
                if (i == j) continue;

                if (current.equalsIgnoreCase(arr[j])) {
                    System.out.print(arr[j] + " ");
                }
            }
            System.out.print("\b\n");
        }
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String[] input = in.nextLine().split("\\s");

        printEqualElements(input);
    }
}
