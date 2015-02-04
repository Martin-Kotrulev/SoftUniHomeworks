import java.util.Scanner;

/**
 * Problem 4. Longest Increasing Sequence
 * Write a program to find all increasing sequences inside an array of integers.
 * The integers are given in a single line, separated by a space.
 * Print the sequences in the order of their appearance in the
 * input array, each at a single line. Separate the sequence elements
 * by a space. Find also the longest increasing sequence and print
 * it at the last line. If several sequences have the same longest
 * length, print the leftmost of them.
 */

public class LongestIncreasingSequenceFinder {
    private static void printSequences(String[] seq) {
        String longest = "";
        String s;

        for (int i = 0; i < seq.length; i++) {
            String current = seq[i];
            s = current;

            for (int j = i + 1; j < seq.length; j++) {

                if (Integer.parseInt(seq[j]) > Integer.parseInt(current)) {
                    s += " " + seq[j];
                    current = seq[j];
                    i++;
                } else break;
            }
            System.out.println(s);
            if (s.length() > longest.length()) longest = s;
        }
        System.out.printf("Longest: %s", longest);
    }

    public static void main(String[] args) {
        Scanner in = new Scanner(System.in);
        String[] seq = in.nextLine().split("\\s");

        printSequences(seq);
    }
}
