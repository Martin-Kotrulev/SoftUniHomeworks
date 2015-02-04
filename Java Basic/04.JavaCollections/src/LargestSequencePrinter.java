import java.util.HashSet;
import java.util.Scanner;

/**
 * Problem 3. Largest Sequence of Equal Strings
 * Write a program that enters an array of strings and finds
 * in it the largest sequence of equal elements. If several
 * sequences have the same longest length, print the leftmost of them.
 * The input strings are given as a single line, separated by a space.
 */

public class LargestSequencePrinter {

    static String findLongestSeq(String[] arr) {
        HashSet<String> checked = new HashSet<>();
        String longest = "";
        String result;

        for (int i = 0; i < arr.length; i++) {
            String current = arr[i];
            result = arr[i];
            if (checked.contains(current)) continue;
            checked.add(current);

            for (int j = 0; j < arr.length; j++) {
                if (i == j) continue;
                if (arr[j].equalsIgnoreCase(current)) {
                    result += " " + arr[j];
                }
            }

            if (result.length() > longest.length()) {
                longest = result;
            }
        }
        return longest;
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String[] input = in.nextLine().split("\\s");

        System.out.println(findLongestSeq(input));
    }
}
